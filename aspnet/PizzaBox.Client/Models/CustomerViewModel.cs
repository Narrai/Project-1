using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Models
{
    public class CustomerViewModel
    {
        public string selectedCustomer { get; set; }
        public IList<Customer> customers {get; set;}

    }
}