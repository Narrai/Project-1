using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing.Repository;

namespace PizzaBox.Client.Controllers
{
    [Route("[controller]")]
    public class StoreController : Controller
    {
        
        private readonly IStoreRepository _storeRepository;
       

        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        [HttpGet]
        [Route("/")]
        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
          
            var storeViewModel = new StoreViewModel()
            {
               
                stores = _storeRepository.GetAllStores()

            };
            
            return View("index", storeViewModel);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Index(StoreViewModel storeViewModel)
        {
            return RedirectToAction("index", "order", new{id = storeViewModel.SelectedStore});
            
        }
    }
}