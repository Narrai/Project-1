using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public interface ISizeRepository
    {
        List<Sizes> GetSizes();
    }
}