using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;

namespace Vidly.Models
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        public ActionResult Index()
        {


            var movies = _context.Movies.Include(c=> c.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int? id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
                }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new List<Movie> {
                new Movie {Name="Shrek" },
                new Movie { Name="Rang De Basanti"}
            };


            var movieModel = new RandomMovieViewModel {
                Movies=movie
            };
            return View(movieModel);
        }

       
    }
}