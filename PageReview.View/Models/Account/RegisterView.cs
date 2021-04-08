﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.View.Models.Account
{
    public class RegisterView
    {
        public string FullName { get; set; }


        public string Address { get; set; }

        public string Gender { get; set; }

        public string DoB { get; set; }

        public string Company { get; set; }

        public string ImagePath { get; set; }

        public string PhoneNumber { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
