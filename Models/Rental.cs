using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        [Display(Name = "Movie")]
        public int MovieId { get; set; }
        public Customer Customer { get; set; }
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
    }
}