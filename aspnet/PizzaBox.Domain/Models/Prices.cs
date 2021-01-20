using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Prices : AModel
    {
        public float Price { get; set; }

        public long SizeEntityId { get; set; }

    }
}