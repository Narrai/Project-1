using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Storing.Repository
{
    public class PizzaBoxRepository
    {
        private PizzaBoxContext _ctx;

        public PizzaBoxRepository(PizzaBoxContext context)
        {
           _ctx = context;
        }

        public  List<string> GetStores()
        {
            return _ctx.Stores.Select(s => s.Name).ToList();
        }
    }
}