using PageReview.Domain.Request.Brand;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Brand;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.BAL.Interface
{
    public interface IBrandService
    {
        Task<Response> save(SaveBrandReq request);
        Task<IEnumerable<BrandView>> Gets();
        Task<BrandView> Get(int id);
        Task<Response> Delete(int id);
    }
}
