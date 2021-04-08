using PageReview.BAL.Interface;
using PageReview.DAL.Interface;
using PageReview.Domain.Request.Brand;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Brand;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.BAL
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            this.brandRepository = brandRepository;
        }
        public async Task<Response> Delete(int id)
        {
            return await brandRepository.Delete(id);
        }

        public async Task<BrandView> Get(int id)
        {
            return await brandRepository.Get(id);
        }

        public async Task<IEnumerable<BrandView>> Gets()
        {
            return await brandRepository.Gets();
        }

        public async Task<Response> save(SaveBrandReq request)
        {
            return await brandRepository.save(request);
        }
    }
}
