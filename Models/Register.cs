using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace eLibrary.Models
{
    public class Register
    {
        [HiddenInput]
        public int Id { get; set; }
        [EmailAddress]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Niepoprawny adres email! ")]
        [Required(ErrorMessage = "Email jest wymagany. ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane. ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Potwierdź swoje hasło. ")]
        [Compare("Password", ErrorMessage = "Hasła muszą do siebie pasować! ")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Musisz podać imię. ")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Musisz podać nazwisko. ")]
        public string LastName { get; set; }
       
       
       
    }

    
}