using System;
using System.Collections.Generic;
using System.Text;

namespace PageReview.Domain.Request.Brand
{
    public class SaveBrandReq
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
