using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public interface IStoreRepository
    {
        // get store by Id
        Store GetStoreById(long id);
        IList<Store> GetAllStores();
        void CreateOrders(Order order);

        float TotalRevenue(long id);
    }
}