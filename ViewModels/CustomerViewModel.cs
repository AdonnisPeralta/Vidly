using vidly.Models;

namespace vidly.ViewModels
{
    public class CustomerViewModel
    {
        public List<Customer>? Customers = new List<Customer>
        {
            new Customer { Name = "Adonnis", Id = 1 },
            new Customer { Name = "Camelia", Id = 2 },
            new Customer { Name = "AJ", Id = 3 },
            new Customer { Name = "Logan", Id = 4 },
            new Customer { Name = "Carter", Id = 5 }
        };  
    }
}
