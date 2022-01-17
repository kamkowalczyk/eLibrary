using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Models
{
    public class Book
    {
        public Book()
        {
            Authors = new HashSet<Author>();
        }

        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać tytuł książki!")]
        [MinLength(2)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Musisz podać  autora!")]
        public ICollection<Author> Authors { get; set; }
       
        public int PublishingYear { get; set; }

        public override string ToString()
        {
            return "{Book: " + Title + " " + PublishingYear + " " + Authors + "}";
        }
    }
}
