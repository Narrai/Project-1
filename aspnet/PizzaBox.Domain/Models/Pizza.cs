using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Pizza : APizzaModel
    {
        protected override void AddCrust()
        {
            Crust = new Crusts().Name;
        }

        protected override void AddPrice()
        {
            Price = new Prices().Price;
        }

        protected override void AddSize()
        {
            Size = new Sizes().Size;
        }
    }
}