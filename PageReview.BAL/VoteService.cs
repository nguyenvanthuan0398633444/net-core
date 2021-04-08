using PageReview.BAL.Interface;
using PageReview.DAL.Interface;
using PageReview.Domain.Request.Vote;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Vote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.BAL
{
    public class VoteService : IVoteService
    {
        private readonly IVoteRepository voteRepository;

        public VoteService(IVoteRepository voteRepository)
        {
            this.voteRepository = voteRepository;
        }
        public async Task<Response> Delete(int id)
        {
            return await voteRepository.Delete(id);
        }

        public async Task<VoteView> Get(int productId, string UserId)
        {
            return await voteRepository.Get(productId, UserId);
        }

        public async Task<Response> Save(SaveVoteReq request)
        {
            return await voteRepository.Save(request);
        }
    }
}
