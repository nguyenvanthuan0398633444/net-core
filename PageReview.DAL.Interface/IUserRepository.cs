using PageReview.Domain;
using PageReview.Domain.Request.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.DAL.Interface
{
    public interface IUserRepository
    {
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<ApplicationUser> Get(string id);
        Task<IEnumerable<ApplicationUser>> Gets();
        Task<IEnumerable<GetUserIdRoleId>> GetsAdmin();
        Task<bool> Update(UpdateUser user);
        Task<bool> ChangePassword(Password user);
    }
}
