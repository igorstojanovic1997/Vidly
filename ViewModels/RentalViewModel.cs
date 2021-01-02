using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RentalViewModel
    {
        public List<Rental> Rentals { get; set; }
    }
}