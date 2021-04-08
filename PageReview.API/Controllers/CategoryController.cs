using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PageReview.BAL.Interface;
using PageReview.Domain.Request.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpPost, HttpPatch]
        [Route("save")]
        public async Task<OkObjectResult> SaveCategory(SaveCategoryReq request)
        {
            var result = await categoryService.Save(request);
            return Ok(result);
        }
        [HttpGet("gets")]
        public async Task<OkObjectResult> Gets()
        {
            var result = await categoryService.Gets();
            return Ok(result);
        }
        [HttpGet("get/{id}")]
        public async Task<OkObjectResult> Get(int id)
        {
            var result = await categoryService.Get(id);
            return Ok(result);
        }
        [HttpPatch("delete/{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            var result = await categoryService.Delete(id);
            return Ok(result);
        }
    }
}
