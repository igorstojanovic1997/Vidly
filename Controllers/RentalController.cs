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
        [Authorize(Roles = RoleName.CanManageRentals)]
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
            if (User.IsInRole(RoleName.CanManageRentals))
                return View("Index");
            else
                return View("ReadOnlyList");


        }
        [Authorize(Roles = RoleName.CanManageRentals)]
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