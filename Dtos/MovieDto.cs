using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestVidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        public DateTime ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; } = DateTime.Now;

        [Required]
        [Range(1, 20)]
        public int Stock { get; set; }

        public GenreDto Genre { get; set; }


        [Required]
        public byte GenreId { get; set; }
    }
}