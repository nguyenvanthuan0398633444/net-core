using PageReview.BAL.Interface;
using PageReview.DAL.Interface;
using PageReview.Domain.Request.Product;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.BAL
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Response> Delete(int id)
        {
            return await productRepository.Delete(id);
        }

        public async Task<ProductView> Get(int id)
        {
            return await productRepository.Get(id);
        }

        public async Task<IEnumerable<ProductView>> Gets()
        {
            return await productRepository.Gets();
        }

        public async Task<IEnumerable<ProductView>> GetsByBrandId(int brandId)
        {
            return await productRepository.GetsByBrandId(brandId);
        }

        public async Task<IEnumerable<ProductView>> GetsByCategoryId(int categoryId)
        {
            return await productRepository.GetsByCategoryId(categoryId);
        }

        public async Task<IEnumerable<ProductView>> GetsByCharacter(string Keyword)
        {
            return await productRepository.GetsByCharacter(Keyword);
        }

        public async Task<IEnumerable<ProductView>> GetsByComment(int Numbercomment)
        {
            return await productRepository.GetsByComment(Numbercomment);
        }

        public async Task<IEnumerable<ProductView>> GetsByPrice(double Price)
        {
            return await productRepository.GetsByPrice(Price);
        }

        public async Task<IEnumerable<ProductView>> GetsByVote(int Numbervote)
        {
            return await productRepository.GetsByVote(Numbervote);
        }

        public async Task<Response> Save(SaveProductReq request)
        {
            return await productRepository.Save(request);
        }
    }
}
