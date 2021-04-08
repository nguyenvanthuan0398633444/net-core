using PageReview.Domain.Request.Product;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.DAL.Interface
{
    public interface IProductRepository
    {
        Task<Response> Save(SaveProductReq request);
        Task<ProductView> Get(int id);
        Task<IEnumerable<ProductView>> GetsByCategoryId(int categoryId);
        Task<IEnumerable<ProductView>> GetsByBrandId(int brandId);
        Task<IEnumerable<ProductView>> GetsByCharacter(string Keyword);
        Task<IEnumerable<ProductView>> GetsByComment(int Numbercomment);
        Task<IEnumerable<ProductView>> GetsByVote(int Numbervote);
        Task<IEnumerable<ProductView>> GetsByPrice(double Price);
        Task<IEnumerable<ProductView>> Gets();
        Task<Response> Delete(int id);
    }
}
