using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Models
{
    public class StoreViewModel
    {
        public string SelectedStore { get; set; }
        public IList<Store> stores {get; set;}

    }
}