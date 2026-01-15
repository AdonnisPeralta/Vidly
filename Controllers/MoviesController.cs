using Microsoft.AspNetCore.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>()
            {
                new Customer { Name = "Camelia" },
                new Customer { Name = "Adonnis" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            return Content("id: " + id);
        }

        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }

            return View();
        }
        [Route("movies/released/{year}/{month:regex(\\d{{1,2}}):range(1, 12)}")]
        public IActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}
