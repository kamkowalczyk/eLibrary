using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace eLibrary.Models
{
    public class Login
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Email jest wymagany.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Podaj hasło.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; } = false;
    }
}
