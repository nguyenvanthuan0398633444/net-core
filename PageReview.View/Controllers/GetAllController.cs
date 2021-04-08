using Microsoft.AspNetCore.Mvc;
using PageReview.View.Models.Product;
using PageReview.View.Ultilities;
using PageReview.View.Views.GetAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.View.Controllers
{
    public class GetAllController : Controller
    {
        public JsonResult getsProductStatus()
        {
            List<ProductStatus> result = ApiHelper<List<ProductStatus>>.HttpGetAsync($"getAll/getsProductStatus");
            return Json(new { result });
        }
        public JsonResult getsImage(int id)
        {
            List<Image> result = ApiHelper<List<Image>>.HttpGetAsync($"getAll/getsImage/{id}");
            return Json(new { result });
        }
        public JsonResult GetProductCommingFirst()
        {
            ProductView result = ApiHelper<ProductView>.HttpGetAsync($"getAll/GetProductCommingFirst");
            return Json(new { result });
        }
        public JsonResult Gets1ProductComment()
        {
            ProductView result = ApiHelper<ProductView>.HttpGetAsync($"getAll/Gets1ProductComment");
            return Json(new { result });
        }
        public JsonResult Gets1ProductVote()
        {
            ProductView result = ApiHelper<ProductView>.HttpGetAsync($"getAll/Gets1ProductVote");
            return Json(new { result });
        }
        public JsonResult Gets5GetsExpensive()
        {
            List<ProductView> result = ApiHelper<List<ProductView>>.HttpGetAsync($"getAll/Gets5GetsExpensive");
            return Json(new { result });
        }
        public JsonResult Gets5ProductComment()
        {
            List<ProductView> result = ApiHelper<List<ProductView>>.HttpGetAsync($"getAll/Gets5ProductComment");
            return Json(new { result });
        }
        public JsonResult Gets5ProductCommingsoon()
        {
            List<ProductView> result = ApiHelper<List<ProductView>>.HttpGetAsync($"getAll/Gets5ProductCommingsoon");
            return Json(new { result });
        }
        public JsonResult Gets5Productnew()
        {
            List<ProductView> result = ApiHelper<List<ProductView>>.HttpGetAsync($"getAll/Gets5Productnew");
            return Json(new { result });
        }
        public JsonResult Gets5Productrandom()
        {
            List<ProductView> result = ApiHelper<List<ProductView>>.HttpGetAsync($"getAll/Gets5Productrandom");
            return Json(new { result });
        }
        public JsonResult Gets5ProductVote()
        {
            List<ProductView> result = ApiHelper<List<ProductView>>.HttpGetAsync($"getAll/Gets5ProductVote");
            return Json(new { result });
        }
        public JsonResult Gets6ProductsameBrand(int id)
        {
            List<ProductView> result = ApiHelper<List<ProductView>>.HttpGetAsync($"getAll/Gets6ProductsameBrand/{id}");
            return Json(new { result });
        }
        public JsonResult Gets6ProductsameCategory(int id)
        {
            List<ProductView> result = ApiHelper<List<ProductView>>.HttpGetAsync($"getAll/Gets6ProductsameCategory/{id}");
            return Json(new { result });
        }
    }
}
