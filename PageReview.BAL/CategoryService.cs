using PageReview.BAL.Interface;
using PageReview.DAL.Interface;
using PageReview.Domain.Request.Category;
using PageReview.Domain.Response;
using PageReview.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PageReview.BAL
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task<Response> Delete(int id)
        {
            return await categoryRepository.Delete(id);
        }

        public async Task<CategoryView> Get(int id)
        {
            return await categoryRepository.Get(id);
        }

        public async Task<IEnumerable<CategoryView>> Gets()
        {
            return await categoryRepository.Gets();
        }

        public async Task<Response> Save(SaveCategoryReq request)
        {
            var kqua = await categoryRepository.Save(request);
            return kqua;
        }
    }
}
