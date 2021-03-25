using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Widly.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}