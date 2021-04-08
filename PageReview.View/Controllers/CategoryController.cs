using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PageReview.View.Models;
using PageReview.View.Models.Category;
using PageReview.View.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.View.Controllers
{
    public class CategoryController : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Gets()
        {
            var result = ApiHelper<IEnumerable<CategoryView>>.HttpGetAsync($"Category/gets");
            return Json(new { result });
        }
        [HttpPost]
        [Route("/category/save")]
        [Authorize(Roles = "Admin")]
        public JsonResult Save([FromBody] SaveCategory request)
        {
            var result = ApiHelper<Result>.HttpPostAsync($"category/save", "POST", request);
            return Json(new { data = result });
        }
        [HttpPost]
        [Route("/category/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public JsonResult Delete(int id)
        {
            var result = ApiHelper<Result>.HttpPatchAsync($"Category/Delete/{id}", null);
            return Json(new { data = result });
        }
        [HttpGet]
        [Route("/category/get/{id}")]
        public JsonResult Get(int id)
        {
            var category = ApiHelper<CategoryView>.HttpGetAsync($"category/get/{id}");
            return Json(new { data = category });
        }
    }
}
