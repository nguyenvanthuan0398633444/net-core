using PageReview.Domain.Request.Brand;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Brand;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PageReview.DAL.Interface
{
    public interface IBrandRepository
    {
        Task<Response> save(SaveBrandReq request);
        Task<IEnumerable<BrandView>> Gets();
        Task<BrandView> Get(int id);
        Task<Response> Delete(int id);
    }
}
