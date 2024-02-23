using Mission6_Stone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;

        public HomeController(MovieContext someName)
        {
            _context = someName ;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Joel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movie()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View("Movie", new Movie());
        }

        [HttpPost]
        public IActionResult Movie(Movie addition)
        {
            addition.LentTo = addition.LentTo ?? "";

            addition.Notes = addition.Notes ?? "";

            if (ModelState.IsValid)
            {
                _context.Movies.Add(addition);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName).ToList();

                return View(addition);
            }

            return RedirectToAction("List");
        }


        public IActionResult List()
        {
            var movies = _context.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title).ToList();
            //var movies = _context.Movies
            //    .Include("Category")
            //    .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            var recordToEdit = _context.Movies.Single(x => x.MovieId == id);

            return View("Movie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updated)
        {
            _context.Update(updated);
            _context.SaveChanges();

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //ViewBag.Movie = _context.Movies
            //    .Where(x => x.MovieId).ToList();

            var recordToDelete = _context.Movies.Single(x => x.MovieId == id);

            return View("Delete", recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie gone)
        {
            _context.Movies.Remove(gone);
            _context.SaveChanges();

            return RedirectToAction("List");
        }
    }
}