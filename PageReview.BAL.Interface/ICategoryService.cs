using PageReview.Domain.Request.Category;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.BAL.Interface
{
    public interface ICategoryService
    {
        Task<Response> Save(SaveCategoryReq request);
        Task<CategoryView> Get(int id);
        Task<IEnumerable<CategoryView>> Gets();
        Task<Response> Delete(int id);
    }
}
