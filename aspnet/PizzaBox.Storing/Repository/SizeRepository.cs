using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public class SizeRepository : ISizeRepository
    {
        private readonly PizzaBoxContext _context;

        public SizeRepository(PizzaBoxContext context)
        {
            _context = context;
        }
        public List<Sizes> GetSizes()
        {
            return _context.Sizes.ToList();
        }
    }
}