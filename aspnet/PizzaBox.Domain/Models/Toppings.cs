using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Toppings : AModel
    {
        public string Name { get; set; }
        public IList<APizzaModel> Pizzas { get; set; }
    }

}