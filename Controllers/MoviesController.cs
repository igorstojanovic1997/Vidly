using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.viewModels;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        // GET: Movies
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek"

            };


            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer{Name = "Mary Williams" }
            };
            var ViewModel = new RandomMovieViewModel
            {

                Movie = movie,
                Customers = customers
            };
            return View(ViewModel);
        }


        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.FirstOrDefault(t => t.Id == id);
            
            return View(movie);
        }

        public ActionResult New()
        {

            return View("MovieForm");
        }

        [HttpPost]
        public ActionResult Add(NewMovieViewModel vm)
        {
            var movieToAdd = vm.Movie;

            if (movieToAdd.Id == 0)
                _context.Movies.Add(movieToAdd);
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movieToAdd.Id);
                TryUpdateModel(movieInDb, "", new string[] { "Name" });
                movieInDb.Name = movieToAdd.Name;
                movieInDb.Genre = movieToAdd.Genre;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}