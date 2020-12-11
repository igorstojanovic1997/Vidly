using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
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


           
            var ViewModel = new RandomMovieViewModel
            {

                Movie = movie
                
            };
            return View(ViewModel);
        }

        
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("Index");
            return View("ReadOnlyList");
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(s => s.MovieType).FirstOrDefault(t => t.Id == id);
            
            return View(movie);
        }

        [System.Web.Mvc.HttpGet]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            var movieTypes = _context.MovieTypes.ToList();
            var viewModel = new NewMovieViewModel()
            {
                Movie = new Movie(),
                MovieTypes = movieTypes
            };

            return View("MovieForm", viewModel);
        }

        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(NewMovieViewModel vm) 
        {
            var movieToAdd = vm.Movie;
            if (!ModelState.IsValid)
            {
                var viewModel = new NewMovieViewModel
                {
                    Movie = movieToAdd,
                    MovieTypes = _context.MovieTypes.ToList()
                };
                return View("MovieForm", viewModel);
            }

            if (movieToAdd.Id == 0)
                _context.Movies.Add(movieToAdd);
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movieToAdd.Id);
                TryUpdateModel(movieInDb, "", new string[] { "Name" });
                movieInDb.Name = movieToAdd.Name;
                movieInDb.MovieTypeId = movieToAdd.MovieTypeId;
                movieInDb.Stock = movieToAdd.Stock;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.FirstOrDefault(t => t.Id == id);
            if (movie == null)

                return HttpNotFound();
            var viewModel = new NewMovieViewModel
            {
                Movie = movie,
                MovieTypes = _context.MovieTypes.ToList()
            };

            return View(viewModel);
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Edit(NewMovieViewModel vm)
        {
            var movieToUpdate = vm.Movie;
            _context.Movies.AddOrUpdate(movieToUpdate);
            _context.SaveChanges();
            return RedirectToAction("Details", new {id = movieToUpdate.Id});
        }
    }
}