using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class RentalController : Controller
    {
        private ApplicationDbContext _context;

        public RentalController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var movies = _context.Movies.ToList();
            var customers = _context.Customers.ToList();
            var viewModel = new NewRentalViewModel()
            {
                Movies = movies,
                Customers = customers
            };

            return View("RentalForm", viewModel);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(NewRentalViewModel vm)
        {
            //var rental = vm.Rental;
            if (!ModelState.IsValid)
            {
                var movies = _context.Movies.ToList();
                var customers = _context.Customers.ToList();
                var viewModel = new NewRentalViewModel()
                {
                    Movies = movies,
                    Customers = customers
                };
                return View("RentalForm", viewModel);
            }


            foreach (var movieId in vm.SelectedMovies)
            {
                var rental = new Rental
                {
                    MovieId = movieId,
                    CustomerId = vm.CustomerId
                };

                var existingRental =
                    _context.Rentals.FirstOrDefault(t => t.CustomerId == vm.CustomerId && t.MovieId == movieId);

                if (existingRental == null)
                {
                    _context.Rentals.Add(rental);
                }

            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Rental");
        }
    }
}