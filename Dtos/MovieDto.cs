using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Widly.Models;

namespace Widly.Dtos
{
    public class MovieDto
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        
        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }

        public GenreDto Genre { get; set; }

        public byte? GenreId { get; set; }

    }
}