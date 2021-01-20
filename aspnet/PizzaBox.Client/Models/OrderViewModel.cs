using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Models
{
    public class OrderViewModel
    {
        [Required]
        public List<Order> orders {get; set;}

        public List<Crusts> crusts { get; set; }

        public List<Sizes> sizes { get; set; }

        public IEnumerable<Toppings> toppings{get; set;}

        public string Crust { get; set; }
        public string Size { get; set; }

        public List<string> Toppings { get; set;}
        
    }
}