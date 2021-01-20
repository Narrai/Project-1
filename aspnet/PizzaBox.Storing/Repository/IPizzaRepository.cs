using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing.Repository
{
    public interface IPizzaRepository
    {
         IList<APizzaModel> Pizzas();
         IList<APizzaModel> GetPizzaByOrders(long OrderId);

         float GetTotalPrice();
    }
}