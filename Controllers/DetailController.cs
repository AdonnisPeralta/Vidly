using Microsoft.AspNetCore.Mvc;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class DetailController : Controller
    {
        [Route("Detail/{id?}")]
        public IActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                var viewModel = new CustomerViewModel();
                var customerModel = viewModel.Customers?.Find(customer => customer.Id == id.Value);
                return View(customerModel);
            }
            return View();
        }
    }
}
