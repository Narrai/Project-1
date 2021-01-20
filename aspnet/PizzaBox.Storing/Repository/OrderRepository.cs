using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly PizzaBoxContext _ptx;

        public OrderRepository(PizzaBoxContext context)
        {
            _ptx = context;   
        }

        public List<Order> GetOrdersByStore()
        {
            return _ptx.Orders.ToList();
        }

        public List<Order> GetOrdersByStore(long storeId)
        {
            return _ptx.Orders.Where(order => order.StoreEntityId == storeId).ToList();
        }

        public void MakePizza(Pizza pizza)
        {
            _ptx.Add<Pizza>(pizza);
            _ptx.SaveChanges();
        }
    }
}