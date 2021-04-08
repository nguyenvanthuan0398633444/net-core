using PageReview.BAL.Interface;
using PageReview.DAL.Interface;
using PageReview.Domain;
using PageReview.Domain.Request.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.BAL
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<string> Authencate(LoginRequest request)
        {
            return await userRepository.Authencate(request);
        }

        public async Task<bool> ChangePassword(Password user)
        {
            return await userRepository.ChangePassword(user);
        }

        public async Task<ApplicationUser> Get(string id)
        {
            return await userRepository.Get(id);
        }

        public async Task<IEnumerable<ApplicationUser>> Gets()
        {
            return await userRepository.Gets();
        }

        public async Task<IEnumerable<GetUserIdRoleId>> GetsAdmin()
        {
            return await userRepository.GetsAdmin();
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            return await userRepository.Register(request);
        }

        public async Task<bool> Update(UpdateUser user)
        {
            return await userRepository.Update(user);
        }
    }
}
