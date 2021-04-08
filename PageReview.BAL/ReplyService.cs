using PageReview.BAL.Interface;
using PageReview.DAL.Interface;
using PageReview.Domain.Request.Comment;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Comment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.BAL
{
    public class ReplyService : IReplyService
    {
        private readonly IReplyRepository replyRepository;

        public ReplyService(IReplyRepository replyRepository)
        {
            this.replyRepository = replyRepository;
        }
        public async Task<Response> Delete(int id)
        {
            return await replyRepository.Delete(id);
        }

        public async Task<IEnumerable<CommentView>> GetsReply(int CommentId, int ProductId)
        {
            return await replyRepository.GetsReply(CommentId, ProductId);
        }

        public async Task<Response> Save(SaveReplyReq request)
        {
            return await replyRepository.Save(request);
        }
    }
}
