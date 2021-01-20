using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing.Repository
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly PizzaBoxContext _ptx;

        public PizzaRepository(PizzaBoxContext context)
        {
            _ptx = context;
        }

        public IList<APizzaModel> GetPizzaByOrders(long OrderId)
        {
            throw new System.NotImplementedException();
        }

        public float GetTotalPrice()
        {
            var pizzas = _ptx.Pizzas.ToList();
            float total = 0;
            foreach(var pizza in pizzas)
            {
                total += pizza.Price;
            }
            return total;
        }

        public IList<APizzaModel> Pizzas()
        {
            return _ptx.Pizzas.Include("Toppings").ToList();
        }
    }
}