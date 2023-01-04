using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestVidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }
        
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; } = DateTime.Now;
        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public int Stock { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
    }
}