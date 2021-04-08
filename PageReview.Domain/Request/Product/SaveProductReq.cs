using System;
using System.Collections.Generic;
using System.Text;

namespace PageReview.Domain.Request.Product
{
    public class SaveProductReq
    {
        public int Id { get; set; }
        public string Productname { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string UserId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime DateofSale { get; set; }
        public int StatusProduct { get; set; }
        public string Image { get; set; }
        public string Images { get; set; }
    }
}
