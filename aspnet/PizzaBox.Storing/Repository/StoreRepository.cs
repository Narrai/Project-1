using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public class StoreRepository : IStoreRepository
    {
        private readonly PizzaBoxContext _ptx;

        public StoreRepository(PizzaBoxContext context)
        {
            _ptx = context;
        }

        public void CreateOrders(Order order)
        {
            _ptx.Orders.Add(order);
            _ptx.SaveChanges();
        }

        public IList<Store> GetAllStores()
        {
            return _ptx.Stores.ToList();
        }

        public Store GetStoreById(long id)
        {
            return _ptx.Stores.Find(id);
        }

        public float TotalRevenue(long id)
        {
            OrderRepository orderRepository = new OrderRepository(_ptx);
            var orders = orderRepository.GetOrdersByStore(id);
            float total = 0;
            foreach(var order in orders)
            {
                total += order.TotalPrice;
            }
            return total;
        }
    }
}