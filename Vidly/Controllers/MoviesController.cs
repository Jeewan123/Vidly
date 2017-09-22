using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Context;
using Vidly.Migrations;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        
        private MovieRentalContext _context;
        public MoviesController()
        {
            _context = new MovieRentalContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movie = _context.Movies.Include(m => m.Genre).ToList();
            return View(movie);
        }

       

        public ActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == Id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);

        }

        public ActionResult New()
        {
            var GenreList = _context.Genres.ToList();
            var genre = new MovieViewModel()
            {
                Movie=new Movie(),
                Genre = GenreList
            };
            return View("MovieForm",genre);
        }

        public ActionResult Edit(int id)
        {
            var movies = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movies==null)
            {
                return HttpNotFound();
            }
            var viewModel = new MovieViewModel()
            {
                Movie = movies,
                Genre = _context.Genres.ToList()
            };
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieViewModel()
                {
                    Movie=movie,
                    Genre = _context.Genres.ToList()
                };
                return View("MovieForm", viewModel);
            }
            movie.DateAdded = DateTime.Now;
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
    }
}