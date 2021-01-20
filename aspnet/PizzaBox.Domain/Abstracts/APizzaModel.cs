using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    public abstract class APizzaModel : AModel
    {        
        public string  Crust { get; set; }
        public string  Size { get; set; }
        public float Price { get; set; }


        protected  abstract void AddCrust();
        protected  abstract void AddSize();

        protected  abstract void AddPrice();

        public IList<Toppings> Toppings { get; set; }
    }
}