using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repository
{
    public class CrustRepository : ICrustRepository
    {
        private readonly PizzaBoxContext _context;

        public CrustRepository(PizzaBoxContext context)
        {
            _context = context;
        }
        public List<Crusts> GetCrusts()
        {
            return _context.Cursts.ToList();
        }
    }
}