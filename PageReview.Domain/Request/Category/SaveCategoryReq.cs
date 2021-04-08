using System;
using System.Collections.Generic;
using System.Text;

namespace PageReview.Domain.Request.Category
{
    public class SaveCategoryReq
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
