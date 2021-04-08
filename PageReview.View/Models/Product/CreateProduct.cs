using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace PageReview.View.Models.Product
{
    public class CreateProduct
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Yêu cầu nhập tên sản phẩm")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Yêu cầu chọn thương hiệu")]
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Yêu cầu chọn kiểu sản phẩm")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập giá")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Yêu cầu chọn trạng thái")]
        public int StatusProduct { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập ngày mở bán")]
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập mô tả")]
        [MinLength(100,ErrorMessage ="Tối Thiểu 100 kí tự")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Yêu cầu chọn ảnh từ máy của bạn")]
        public IFormFile Image { get; set; }
        [Required(ErrorMessage = "Yêu cầu chọn ảnh từ máy của bạn")]
        public IFormFile[] Images { get; set; }
    }
}
