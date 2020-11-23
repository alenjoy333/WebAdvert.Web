﻿using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models
{
    public class SignupModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage = "Password must be at least six characters long")]
        [Display(Name = "Password")]

        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password should be same")]
        public string ConfirmPassword { get; set; }
    }
}
