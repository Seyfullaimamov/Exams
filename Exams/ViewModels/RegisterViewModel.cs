﻿
using System.ComponentModel.DataAnnotations;


namespace Exams.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmed Password")]
        [Compare("Password", ErrorMessage = "Password not correct.")]
        public string ConfirmedPassword { get; set; }
    }
}
