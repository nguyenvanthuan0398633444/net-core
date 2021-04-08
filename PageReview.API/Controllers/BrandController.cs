using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PageReview.BAL.Interface;
using PageReview.Domain.Request.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService brandService;

        public BrandController(IBrandService brandService)
        {
            this.brandService = brandService;
        }
        [HttpPost, HttpPatch]
        [Route("save")]
        public async Task<OkObjectResult> Save(SaveBrandReq request)
        {
            var result = await brandService.save(request);
            return Ok(result);
        }
        [HttpGet("gets")]
        public async Task<OkObjectResult> Gets()
        {
            var result = await brandService.Gets();
            return Ok(result);
        }
        [HttpGet("get/{id}")]
        public async Task<OkObjectResult> Get(int id)
        {
            var result = await brandService.Get(id);
            return Ok(result);
        }
        [HttpPatch("delete/{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            var result = await brandService.Delete(id);
            return Ok(result);
        }
    }
}
