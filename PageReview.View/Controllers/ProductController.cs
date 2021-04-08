using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PageReview.View.Models;
using PageReview.View.Models.Product;
using PageReview.View.Ultilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.View.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment webHost;

        public ProductController(IWebHostEnvironment webHost)
        {
            this.webHost = webHost;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Gets()
        {
            List<ProductView> result = ApiHelper<List<ProductView>>.HttpGetAsync($"Product/gets");
            return Json(new { result });
        }
        [HttpGet("/Product/getsbycategory/{id}")]
        public JsonResult Getbycategory(int id)
        {
            List<ProductView> result = ApiHelper<List<ProductView>>.HttpGetAsync($"Product/getsbycategory/{id}");
            return Json(new { result });
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Save()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Save(CreateProduct request)
        {
            var product = new SaveProduct()
            {
                BrandId = request.BrandId,
                UserId = request.UserId,
                CategoryId = request.CategoryId,
                DateofSale = request.Date,
                Price = request.Price,
                ProductName = request.ProductName,
                StatusProduct = request.StatusProduct,
                Description = request.Description,
                Id = request.Id
            };
            if (request.Id != 0)
            {
                var product1 = ApiHelper<ProductView>.HttpGetAsync($"Product/get/{request.Id}");
                string uploadFolder = Path.Combine(webHost.WebRootPath, "images");
                if (global::System.IO.File.Exists(Path.Combine(uploadFolder, product1.Image)))
                {
                    // If file found, delete it    
                    global::System.IO.File.Delete(Path.Combine(uploadFolder, product1.Image));
                }

            }
            
            product.Image = Img(request.Image);

            product.Images = SaveImg(request.Images, product.Id);
            var result = ApiHelper<Result>.HttpPostAsync($"product/save", "POST", product);
            if(request.Id != 0)
            {
                return Ok(result);
            }
            else
            {
                ViewBag.Message = result.Message;
                return View();
            }
            
        }
        [HttpPost("/product/saveImg")]
        [Authorize(Roles = "Admin")]
        public string SaveImg(IFormFile[] ImageFiles, int id)
        {
            string imgs = "";
            if (ImageFiles != null)
            {
                var iamge = ImageFiles.ToList();
                string uploadFolder = Path.Combine(webHost.WebRootPath, "images");
                if (id != 0)
                {
                    var images = ApiHelper<List<Image>>.HttpGetAsync($"GetAll/getsImage/{id}");
                    
                    foreach (var item in images)
                    {
                        if (global::System.IO.File.Exists(Path.Combine(uploadFolder, item.PathImage)))
                        {
                            // If file found, delete it    
                            global::System.IO.File.Delete(Path.Combine(uploadFolder, item.PathImage));
                        }
                    }

                }
                for (int i = 0; i < iamge.Count; i++)
                {
                    string fileName = $"{Guid.NewGuid()}_{iamge[i].FileName}";
                    
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        iamge[i].CopyTo(fs);
                    }

                    if (imgs == "")
                        imgs += fileName;
                    else
                        imgs += "%" + fileName;
                }
            }
            return imgs;
        }
        public string Img(IFormFile Image)
        {
            string FileImage = null;
            if (Image != null)
            {
                string uploadsFolder = Path.Combine(webHost.WebRootPath, "images");
                FileImage = Guid.NewGuid().ToString() + "_" + Image.FileName;
                string filePath = Path.Combine(uploadsFolder, FileImage);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Image.CopyTo(fileStream);
                }
            }
            return FileImage;
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Route("/product/delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = ApiHelper<Result>.HttpPatchAsync($"product/Delete/{id}", null);
            return Json(new { data = result });
        }
        [HttpGet]
        [Route("/product/getview/{id}")]
        public IActionResult Update(int id)
        {
            var game = ApiHelper<ProductView>.HttpGetAsync($"product/get/{id}");
            return View(game);
        }
        [HttpGet]
        [Route("/product/get/{id}")]
        public IActionResult get(int id)
        {
            var game = ApiHelper<ProductView>.HttpGetAsync($"product/get/{id}");
            return Ok(game);
        }
    }
}
