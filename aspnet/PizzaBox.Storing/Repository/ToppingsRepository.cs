using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public class ToppingsRepository : IToppingsRepository
    {
        private readonly PizzaBoxContext _context;

        public ToppingsRepository(PizzaBoxContext context)
        {
            _context = context;
        }
        public IEnumerable<Toppings> GetToppings()
        {
            
            var toppings = _context.Toppings.ToList();
            return toppings.GroupBy(x => x.Name).Select(y => y.FirstOrDefault());
        }

        public List<APizzaModel> GetAPizzas()
        {
            return _context.Pizzas.Include("Toppings").ToList();
        }

        public void AddToppings(List<string> toppingsList)
        {
            List<Toppings> pizzaToppings = new List<Toppings>();
             foreach(var topping in toppingsList){
               pizzaToppings.Add(
                   new Toppings{
                       Name = topping
                   }
               );
            }

            var pizza = _context.Pizzas.Include("Toppings").OrderBy(p => p.EntityId).LastOrDefault();
            pizza.Toppings = pizzaToppings;
        }
    }
}