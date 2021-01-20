using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public interface ICustomerRepository
    {
        string Name();
        void CreateCustomer();

        List<Customer> GetCustomers();
    }
}