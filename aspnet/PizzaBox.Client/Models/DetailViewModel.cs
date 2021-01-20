using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Models
{
    public class DetailViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<APizzaModel> Pizzas { get; set; }
        public float TotalPrice { get; set; }

        public float TotalPizzaPrice { get; set; }
    }
}