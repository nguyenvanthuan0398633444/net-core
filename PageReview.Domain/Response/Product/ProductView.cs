using System;
using System.Collections.Generic;
using System.Text;

namespace PageReview.Domain.Response.Product
{
    public class ProductView
    {
        public int Id { get; set; }
        public string Productname { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime DateofSale { get; set; }
        public int StatusProduct { get; set; }
        public string TrangThai { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public double NumberofVote { get; set; }
        public int NumberofComment { get; set; }
        public int NumberVote { get; set; }
        public bool Deleted { get; set; }
    }
}
