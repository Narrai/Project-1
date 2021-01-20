using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        private readonly ICrustRepository _crustRepository;
        private readonly IToppingsRepository _toppingsRepository;
        private readonly ISizeRepository _sizeRepository;
        private readonly IStoreRepository _storeRepository;

        private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();

       public OrderController(IOrderRepository orderRepository, ICrustRepository crustRepository, ISizeRepository sizeRepository, 
       IToppingsRepository toppingsRepository, IStoreRepository storeRepository)
        {

            _orderRepository = orderRepository;
            _crustRepository = crustRepository;
            _sizeRepository = sizeRepository;
            _toppingsRepository = toppingsRepository;
            _storeRepository = storeRepository;
        }

        [HttpGet]

        [Route("[action]/{id}")]
       public IActionResult Index(long id)
       {
            ViewBag.SelectedStore = id;
            OrderViewModel orderViewModel = new OrderViewModel(){
                orders = _orderRepository.GetOrdersByStore(id),
                crusts = _crustRepository.GetCrusts(),
                sizes = _sizeRepository.GetSizes(),
                toppings = _toppingsRepository.GetToppings()
            };
           
           return View("order", orderViewModel);
       }

        [HttpPost]
        [Route("[action]/{id}")]
        public IActionResult Index(OrderViewModel orderViewModel, long id)
        {
            Pizza pizza = new Pizza(){
                    Crust = orderViewModel.Crust,
                    Size = orderViewModel.Size,
                    Price = Price(orderViewModel.Size),
            };
            
            
            _orderRepository.MakePizza(pizza);
            _toppingsRepository.AddToppings(orderViewModel.Toppings);

            Order order = new Order(){
               StoreEntityId = id,
               DateModified = DateTime.Now,
               TotalPrice = pizza.Price
            };

            // adding order to customer
            List<Order> orders = new List<Order>();
            orders.Add(order);
            Customer customer = new Customer();
            customer.Orders = orders;

            // adding pizza to orders
            List<APizzaModel> pizzas = new List<APizzaModel>();
            pizzas.Add(pizza);
            order.Pizzas = pizzas;

            _storeRepository.CreateOrders(order);


            return RedirectToAction("index", "detail", new{id = id});
        }

        private float Price(string size)
        {
            float price = 0;
            switch(size)
            {
                case "small":
                    price = 10.99f;
                    break;
                case "medium":
                    price = 12.99f;
                    break;
                case "large":
                    price = 14.99f;
                    break;
                default:
                    break;
            }
            return price;
        }

    }
}