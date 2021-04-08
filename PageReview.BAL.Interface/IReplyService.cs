using PageReview.Domain.Request.Comment;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Comment;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PageReview.BAL.Interface
{
    public interface IReplyService
    {
        Task<Response> Save(SaveReplyReq request);
        Task<IEnumerable<CommentView>> GetsReply(int CommentId, int ProductId);
        Task<Response> Delete(int id);
    }
}
