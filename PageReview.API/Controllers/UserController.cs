using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PageReview.BAL.Interface;
using PageReview.Domain;
using PageReview.Domain.Request.User;
using PageReview.Domain.Response;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration config;

        public UserController(IUserService userService, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager, IConfiguration config)
        {
            this.userService = userService;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.config = config;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var resultToken = await userService.Authencate(request);
            var kqua = new Response();
            if (string.IsNullOrEmpty(resultToken))
            {
                kqua.Id = 0;
                kqua.Message = "Username or password is incorrect.";
                return Ok(kqua);
            }
            kqua.Id = 1;
            kqua.Message = "Login Success";
            return Ok(kqua);
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await userService.Register(request);
            var kqua = new Response();
            if (!result)
            {
                kqua.Id = 0;
                kqua.Message = "Register is unsuccessful!";
                return Ok(kqua);
            }
            kqua.Id = 1;
            kqua.Message = "Register is successful!";
            return Ok(kqua);
        }
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return Ok(new Response() {Id =1 ,Message = "Logout success" });
        }
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(string id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await userService.Get(id);

            return Ok(result);
        }
        [HttpGet("GetInfo/{userName}")]
        public async Task<IActionResult> GetInfo(string userName)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var user = await userManager.FindByNameAsync(userName);
            if(user != null)
            {
                var result = await userService.Get(user.Id);
                return Ok(result);
            }
            return Ok(new ApplicationUser() { });
        }
        [HttpGet("Gets")]
        [AllowAnonymous]
        public async Task<IActionResult> Gets()
        {
            if (!ModelState.IsValid)
                return Ok(ModelState);

            var result = await userService.Gets();

            return Ok(result);
        }
        [HttpGet("GetsAdmin")]
        [AllowAnonymous]
        public async Task<IActionResult> GetsAdmin()
        {
            if (!ModelState.IsValid)
                return Ok(ModelState);

            var result = await userService.GetsAdmin();

            return Ok(result);
        }
        [HttpPost("ChangeStatus/{userId}")]
        public async Task<IActionResult> ChangeStatus(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user.IsDelete)
                user.IsDelete = false;
            else
                user.IsDelete = true;

            await userManager.UpdateAsync(user);
            
            return Ok(new Response() {Id =1, Message="success" });
        }
        [HttpPost("addRole/{userId}")]
        public async Task<IActionResult> AddRole(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            var tam = await userManager.IsInRoleAsync(user, "Admin");
            if (!tam)
            {
                var tam1 = await userManager.AddToRoleAsync(user, "Admin");
                return Ok(new Response() { Id = 1, Message = "add" });
            }
            else
            {
                var tam1 = await userManager.RemoveFromRoleAsync(user, "Admin");
                return Ok(new Response() {Id = 1, Message="remove" });
            }

        }
        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateUser user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await userService.Update(user);
            var kqua = new Response();
            if (!result)
            {
                kqua.Id = 0;
                kqua.Message = "Update is unsuccessful!";
                return Ok(kqua);
            }
            kqua.Id = 1;
            kqua.Message = "Update is successful!";
            return Ok(kqua);
        }
        [HttpPut("changepassword")]
        public async Task<IActionResult> ChangePassword(Password pass)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await userService.ChangePassword(pass);
            var kqua = new Response();
            if (!result)
            {
                kqua.Id = 0;
                kqua.Message = "Change password is unsuccessful!";
                return Ok(kqua);
            }
            kqua.Id = 1;
            kqua.Message = "Change password is successful!";
            return Ok(kqua);
        }
        [HttpPost("ResetPass")]
        public async Task<IActionResult> resetpass(Resetpass pass)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var user = await userManager.FindByIdAsync(pass.Id);

            await userManager.RemovePasswordAsync(user);

            var result = await userManager.AddPasswordAsync(user, pass.PassWord);
            var kqua = new Response() { };
            if (result.Succeeded)
            {
                
                 kqua.Id = 1; kqua.Message = "success" ;
            }
            else
            {
                
                 kqua.Id = 0; kqua.Message = "fail" ;
            }

        
            return Ok(kqua);
        }
    }
}
