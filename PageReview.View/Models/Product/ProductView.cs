using System;
using System.Collections.Generic;

namespace PageReview.View.Models.Product
{
    public class ProductView
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public int StatusProduct { get; set; }
        public string Description { get; set; }
        public string TrangThai { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public DateTime DateofSale { get; set; }
        public string UserId { get; set; }
        public string Image { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public string Status { get; set; }
        public double NumberofVote { get; set; }
        public int NumberofComment { get; set; }
        public int NumberVote { get; set; }
        public bool Deleted { get; set; }
    }
}
