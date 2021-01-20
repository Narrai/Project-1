using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public interface ICrustRepository
    {
         List<Crusts> GetCrusts();
    }
}