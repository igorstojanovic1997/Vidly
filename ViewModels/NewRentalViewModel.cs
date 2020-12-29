using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewRentalViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        [Required]
        public int[] SelectedMovies { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}