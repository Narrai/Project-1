using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly PizzaBoxContext _ptx;

        public CustomerRepository(PizzaBoxContext context)
        {
            _ptx = context;
        }

        public void CreateCustomer()
        {
            
        }

        public List<Customer> GetCustomers()
        {
            return _ptx.Customers.ToList();
        }

        public string Name()
        {
            return _ptx.Customers.Select(c => c.Name).ToString();
        }

        
    }
}