using PageReview.Domain.Request.Category;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PageReview.DAL.Interface
{
    public interface ICategoryRepository
    {
        Task<Response> Save(SaveCategoryReq request);
        Task<CategoryView> Get(int id);
        Task<IEnumerable<CategoryView>> Gets();
        Task<Response> Delete(int id);
    }
}
