using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PageReview.View.Models;
using PageReview.View.Models.Brand;
using PageReview.View.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.View.Controllers
{
    public class BrandController : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Gets()
        {
            List<BrandView> result = ApiHelper<List<BrandView>>.HttpGetAsync($"brand/gets");
            return Json(new { result });
        }
        [HttpPost]
        [Route("/brand/save")]
        [Authorize(Roles = "Admin")]
        public JsonResult Save([FromBody] SaveBrand request)
        {
            var result = ApiHelper<Result>.HttpPostAsync($"brand/save", "POST", request);
            return Json(new { data = result });
        }
        [HttpPost]
        [Route("/brand/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var result = ApiHelper<Result>.HttpPatchAsync($"Brand/Delete/{id}", null);
            return Json(new { data = result });
        }
        [HttpGet]
        [Route("/brand/get/{id}")]
        public JsonResult Get(int id)
        {
            var brand = ApiHelper<BrandView>.HttpGetAsync($"brand/get/{id}");
            return Json(new { data = brand });
        }
    }
}
