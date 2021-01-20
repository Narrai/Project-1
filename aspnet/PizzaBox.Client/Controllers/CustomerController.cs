// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Configuration;
// using PizzaBox.Client.Models;
// using PizzaBox.Domain.Models;
// using PizzaBox.Storing;
// using PizzaBox.Storing.Repository;

// namespace PizzaBox.Client.Controllers
// {
//     [Route("[controller]")]
//     public class CustomerController : Controller
//     {
//         private readonly ICustomerRepository _customerRepository;
       

//         public CustomerController(ICustomerRepository customerRepository)
//         {
//             _customerRepository = customerRepository;
//         }
//         [HttpGet]
//         [Route("[action]")]
//         public IActionResult Index()
//         {
          
//             var customerViewModel = new CustomerViewModel()
//             {
               
//                 customers = _customerRepository.GetCustomers()

//             };
            
//             return View("index", customerViewModel);
//         }

//         [HttpPost]
//         [Route("[action]")]
//         public IActionResult Index(CustomerViewModel customerViewModel)
//         {
//             return RedirectToAction("index", "order", new{id = customerViewModel.selectedCustomer});
            
//         }
//     }
// }