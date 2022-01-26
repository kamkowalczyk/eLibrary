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
        [Required(ErrorMessage = "Musisz podać tytuł książki! ")]
        [MinLength(2, ErrorMessage = "Tytuł powinien zabierać przynajmniej 2 znaki. ")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Musisz podać  autora! ")]
        public string Authors { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        [Required(ErrorMessage = "Musisz podać datę publikacji! ")]
        public DateTime? PublishingYear { get; set; }
        [Required(ErrorMessage = "Musisz podać numer ISBN!" )]
        [MinLength(13, ErrorMessage = "ISBN musi mieć 13 cyfr" ), MaxLength(13, ErrorMessage = "ISBN musi mieć 13 cyfr" )]
        [RegularExpression("^[0-9]+$", ErrorMessage = "To pole powinno zawierać same liczny.  ")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Musisz podać ilość stron!" )]
        public int Pages { get; set; }

   

        public override string ToString()
        {
            return "{Książka: " + Title + " " +  Authors + " " + PublishingYear + " " + ISBN + " " + Pages + "}";
        }
      
    }
}
