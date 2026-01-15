using Microsoft.AspNetCore.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        [Route("Customers/{id?}")]
        public IActionResult Index(int? id)
        {
            var viewModel = new CustomerViewModel();
            return View(viewModel);
        }
    }
}
