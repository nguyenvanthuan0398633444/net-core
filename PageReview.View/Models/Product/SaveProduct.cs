using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.View.Models.Product
{
    public class SaveProduct
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public int StatusProduct { get; set; }
        public DateTime DateofSale { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Images { get; set; }
    }
}
