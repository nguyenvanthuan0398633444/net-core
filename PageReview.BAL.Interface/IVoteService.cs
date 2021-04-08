using PageReview.Domain.Request.Vote;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Vote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.BAL.Interface
{
    public interface IVoteService
    {
        Task<Response> Save(SaveVoteReq request);
        Task<VoteView> Get(int productId, string UserId);
        Task<Response> Delete(int id);
    }
}
