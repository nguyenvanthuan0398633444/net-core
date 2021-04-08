using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PageReview.Domain.Request.User
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "FullName is required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Address is required")]

        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Birthday is required")]
        public DateTime DoB { get; set; }

        public string Company { get; set; }

        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression(@"^\(?(0|[3|5|7|8|9])+([0-9]{8})$", ErrorMessage = "Số điện thoại không hợp lệ!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="ConfirmPassword must match password")]
        public string ConfirmPassword { get; set; }
    }
}
