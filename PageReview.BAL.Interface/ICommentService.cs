using PageReview.Domain.Request.Comment;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Comment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.BAL.Interface
{
    public interface ICommentService
    {
        Task<Response> Save(SaveCommentReq request);
        Task<Response> SaveRep(SaveReplyReq request);
        Task<IEnumerable<CommentView>> GetsComment(int id);
        Task<IEnumerable<CommentView>> GetsReply(int productId, int commentId);
        Task<Response> Delete(int id);
        Task<CommentView> Get(int id);
    }
}
