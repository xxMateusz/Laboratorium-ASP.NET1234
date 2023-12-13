using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium3___App.Models
{
    public class Post
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole 'Zawartość' jest wymagane")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Pole 'Autor' jest wymagane")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }

        public string Tags { get; set; }

        public string Comment { get; set; }
    }
}
