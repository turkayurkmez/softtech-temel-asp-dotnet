﻿using System.ComponentModel.DataAnnotations;

namespace SimpleEShop.MVC.Models
{
    public class UserLoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string? ReturnUrl { get; set; }

    }
}
