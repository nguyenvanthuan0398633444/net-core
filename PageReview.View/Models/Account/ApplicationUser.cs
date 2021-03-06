using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PageReview.View.Models.Account
{
    public class ApplicationUser :IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string DoB { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public bool IsDelete { get; set; }
    }
}
