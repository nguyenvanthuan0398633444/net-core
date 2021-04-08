using PageReview.Domain.Response.GetAll;
using PageReview.Domain.Response.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PageReview.DAL.Interface
{
    public interface IGetAllRepository
    {
        Task<IEnumerable<StatusProduct>> GetsProductStatus();
        Task<IEnumerable<GetsImage>> GetsGetsImage(int id);
        Task<ProductView> Gets1ProductComment();
        Task<ProductView> Gets1ProductVote();
        Task<IEnumerable<ProductView>> Gets5ProductComment();
        Task<ProductView> GetProductCommingFirst();
        Task<IEnumerable<ProductView>> Gets5ProductCommingsoon();
        Task<IEnumerable<ProductView>> Gets5Productnew();
        Task<IEnumerable<ProductView>> Gets5Productrandom();
        Task<IEnumerable<ProductView>> Gets5ProductVote();
        Task<IEnumerable<ProductView>> Gets5GetsExpensive();
        Task<IEnumerable<ProductView>> Gets6ProductsameBrand(int id);
        Task<IEnumerable<ProductView>> Gets6ProductsameCategory(int id);
    }
}
