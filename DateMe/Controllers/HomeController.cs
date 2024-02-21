using Mission6_Stone.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            return View();
        }

        [HttpPost]
        public IActionResult Movie (Application response)
        {
            response.Lent = response.Lent ?? "";

            response.Notes = response.Notes ?? "";

            _context.Application.Add(response);
            _context.SaveChanges();

            // var movieSet = _context.Movies.Include(x => x.Category).ToList();

            // x.CategoryName

            return View(response);
        }
    }
}
