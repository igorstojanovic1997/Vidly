using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models.CustomValidation;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Genre { get; set; }
        [MovieReleaseDateValidation]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
        [MovieStockValidation]
        public int Stock { get; set; }
        public MovieType MovieType { get; set; }

        [Display (Name = "Select Genre")]
        public byte MovieTypeId { get; set; }
        
    }
}