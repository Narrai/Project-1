using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public interface IOrderRepository
    {
         List<Order> GetOrdersByStore(long storeId);
         void MakePizza(Pizza pizza);
    }
}