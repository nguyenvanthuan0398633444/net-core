using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using PageReview.DAL.Interface;
using PageReview.Domain;
using PageReview.Domain.Request.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.DAL
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _config;

        public UserRepository(UserManager<ApplicationUser> userManager,
                               SignInManager<ApplicationUser> signInManager,
                               RoleManager<IdentityRole> roleManager, IConfiguration config
                               )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            _config = config;
        }
        public async Task<string> Authencate(LoginRequest request)
        {
            var user = await userManager.FindByNameAsync(request.UserName);
            if (user == null) return null;

            var result = await signInManager.PasswordSignInAsync(user, request.PassWord, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return null;
            }
            var roles = userManager.GetRolesAsync(user);
            return $"Login success";
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var user = new ApplicationUser()
            {
                UserName = request.UserName,
                DoB = request.DoB.ToString("dd/MM/yyyy"),
                Address = request.Address,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Company = request.Company,
                FullName = request.FullName,
                Gender = request.Gender,
                ImagePath = request.ImagePath,
                IsDelete = false
            };
            var result = await userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }
        public async Task<string> Logout()
        {
            await signInManager.SignOutAsync();
            return "Logout Success";
        }

        public async Task<ApplicationUser> Get(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                var result = new ApplicationUser()
                {
                    Address = user.Address,
                    Email = user.Email,
                    FullName = user.FullName,
                    Id = user.Id,
                    PhoneNumber = user.PhoneNumber,
                    UserName = user.UserName,
                    ImagePath = user.ImagePath,
                    DoB = user.DoB,
                    Company = user.Company,
                    Gender = user.Gender
                };
                return result;
            }
            return new ApplicationUser();
        }

        public async Task<IEnumerable<ApplicationUser>> Gets()
        {
            var user = userManager.Users;
            var users = new List<ApplicationUser>();
            foreach (var item in user)
            {
                if (!item.IsDelete)
                {
                    users.Add(item);
                }
            }
            return users;
        }
        

        public async Task<bool> Update(UpdateUser model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                user.Address = model.Address;
                user.Email = model.Email;
                user.FullName = model.FullName;
                user.PhoneNumber = model.PhoneNumber;
                user.UserName = model.UserName;
                user.ImagePath = model.ImagePath;
                user.DoB = model.DoB.ToString("dd/MM/yyyy");
                user.Company = model.Company;
                user.Gender = model.Gender;

                var result = await userManager.UpdateAsync(user);
                return true;
            }
            return false;
        }

        public async Task<bool> ChangePassword(Password user)
        {
            var result = await userManager.ChangePasswordAsync(userManager.FindByNameAsync(user.username).Result, user.OldPassword, user.NewPassword);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<GetUserIdRoleId>> GetsAdmin()
        {
            return await SqlMapper.QueryAsync<GetUserIdRoleId>(connection, "sp_GetsAdmin", CommandType.StoredProcedure);
        }
    }
}
