using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public interface IToppingsRepository
    {
         IEnumerable<Toppings> GetToppings();
         
         void AddToppings(List<string> toppingsList);
    }
}