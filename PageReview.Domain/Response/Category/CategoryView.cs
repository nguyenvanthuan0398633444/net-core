using System;
using System.Collections.Generic;
using System.Text;

namespace PageReview.Domain.Response.Category
{
    public class CategoryView
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Status { get; set; }
    }
}
