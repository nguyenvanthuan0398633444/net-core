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
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }
        public async Task<Response> Delete(int id)
        {
            return await commentRepository.Delete(id);
        }

        public async Task<CommentView> Get(int id)
        {
            return await commentRepository.Get(id);
        }

        public async Task<IEnumerable<CommentView>> GetsComment(int id)
        {
            return await commentRepository.GetsComment(id);
        }

        public async Task<IEnumerable<CommentView>> GetsReply(int productId, int commentId)
        {
            return await commentRepository.GetsReply(productId, commentId);
        }

        public async Task<Response> Save(SaveCommentReq request)
        {
            return await commentRepository.Save(request);
        }

        public async Task<Response> SaveRep(SaveReplyReq request)
        {
            return await commentRepository.SaveRep(request);
        }
    }
}
