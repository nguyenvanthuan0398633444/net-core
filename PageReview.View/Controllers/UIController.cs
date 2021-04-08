using Microsoft.AspNetCore.Mvc;
using PageReview.View.Models.Product;
using PageReview.View.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace PageReview.View.Controllers
{
    public class UIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult All(int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            var products = ApiHelper<List<ProductView>>.HttpGetAsync($"Product/gets");
            return View(products.ToPagedList(pageNumber, pageSize));
        }
        [Route("/UI/GetsbyVote/{mucvote}")]
        public IActionResult GetsbyVote(int mucvote, int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            ViewBag.Mucvote = mucvote;
            var products = ApiHelper<List<ProductView>>.HttpGetAsync($"Product/GetsbyVote/{mucvote}");
            return View(products.ToPagedList(pageNumber, pageSize));
        }
        [Route("/UI/getsbyprice/{price}")]
        public IActionResult getsbyprice(int price, int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            ViewBag.Price = price;
            var products = ApiHelper<List<ProductView>>.HttpGetAsync($"Product/getsbyprice/{price}");
            return View(products.ToPagedList(pageNumber, pageSize));
        }
        [Route("/UI/getsbycomment/{muccommet}")]
        public IActionResult getsbycomment(int muccommet, int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            ViewBag.Muccoment = muccommet;
            var products = ApiHelper<List<ProductView>>.HttpGetAsync($"Product/getsbycomment/{muccommet}");
            return View(products.ToPagedList(pageNumber, pageSize));
        }
        [Route("/UI/getsbycharacter")]
        public IActionResult getsbycharacter(string keyword, int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            ViewBag.keyword = keyword;
            var products = ApiHelper<List<ProductView>>.HttpGetAsync($"Product/getsbycharacter/{keyword}");
            return View(products.ToPagedList(pageNumber, pageSize));
        }
        [Route("/UI/getsbybrand/{id}")]
        public IActionResult getsbybrand(int id, int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            var products = ApiHelper<List<ProductView>>.HttpGetAsync($"Product/getsbybrand/{id}");
            return View(products.ToPagedList(pageNumber, pageSize));
        }
        [Route("/UI/getsbycategory/{id}")]
        public IActionResult getsbycategory(int id, int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            var products = ApiHelper<List<ProductView>>.HttpGetAsync($"Product/getsbycategory/{id}");
            return View(products.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult Details(int id)
        {
            var products = ApiHelper<ProductView>.HttpGetAsync($"Product/get/{id}");
            return View(products);
        }
    }
}
