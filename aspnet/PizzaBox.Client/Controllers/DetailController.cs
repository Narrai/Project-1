using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{
    [Route("[controller]")]
    public class DetailController : Controller
    {
         private readonly IOrderRepository _orderRepository;
        private readonly IStoreRepository _storeRepository;
         private readonly IPizzaRepository _pizzaRepository;
        public DetailController(IOrderRepository orderRepository, IPizzaRepository pizzaRepository, IStoreRepository storeRepository)
        {
            _orderRepository = orderRepository;
            _pizzaRepository = pizzaRepository;
            _storeRepository = storeRepository;
        }

        [HttpGet]

        [Route("[action]/{id}")]
        public IActionResult Index(long id)
        {
            ViewBag.StoreId = id;
            DetailViewModel detailViewModel = new DetailViewModel(){
                Orders = _orderRepository.GetOrdersByStore(id),
                Pizzas = _pizzaRepository.Pizzas(),
                TotalPrice = _storeRepository.TotalRevenue(id),
                TotalPizzaPrice = _pizzaRepository.GetTotalPrice()

            };
    
            return View("detail", detailViewModel);
    
        }
    }
}