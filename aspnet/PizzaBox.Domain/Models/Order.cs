using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Order : AModel
    {
        public long StoreEntityId { get; set; }
        public Store Store { get; set; }
        
        public float TotalPrice { get; set; }   
        public DateTime DateModified { get; set; }
        public List<APizzaModel> Pizzas { get; set; }
    }
}