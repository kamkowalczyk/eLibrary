using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Models
{
    public class Book
    {
       
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać tytuł książki!")]
        [MinLength(2)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Musisz podać  autora!")]
        public string Authors { get; set; }
        [Required(ErrorMessage = "Musisz podać rok publikacji!")]
        [DataType(DataType.Date)]
        public DateTime PublishingYear { get; set; }
        [Required(ErrorMessage = "Musisz numer ISBN!")]
        [MinLength(13, ErrorMessage = "ISBN musi mieć 8 cyfr"), MaxLength(13, ErrorMessage = "ISBN musi mieć 8 cyfr")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Musisz podać ilość stron!")]
        public int Pages { get; set; }

   

        public override string ToString()
        {
            return "{Książka: " + Title + " " +  Authors + " " + PublishingYear + " " + ISBN + " " + Pages + "}";
        }
      
    }
}
