using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_Course_App.Models;

namespace Vidly_Course_App.Dtos
{
    public class MoviesDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

//        [MinOneMovieInStock]
        public byte NumberInStock { get; set; }
                
        [Required]
        public byte GenreId { get; set; }

        public GenreDto Genre{ get; set; }
    }
}