using PageReview.Domain.Request.Comment;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Comment;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PageReview.DAL.Interface
{
    public interface IReplyRepository
    {
        Task<Response> Save(SaveReplyReq request);
        Task<IEnumerable<CommentView>> GetsReply(int CommentId, int ProductId);
        Task<Response> Delete(int id);
    }
}
