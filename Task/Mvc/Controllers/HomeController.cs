using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using BusinessLogic.Services;
using DataAcess.Entitites;
using DataAcess.Interfaces;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly StoreService _storeService;
        //private readonly ProductService _productService;

        public HomeController()
        {
        }

        public HomeController(IRepository<Store> storeRepository, IRepository<Product> productRepository)
        {
            _storeService = new StoreService(storeRepository);
            //_productService = new ProductService(productRepository);
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            List<Store> storeEntitites = await Task.Run(() => _storeService.GetAll().ToList());
            ViewBag.StoreEntities = storeEntitites;
            return View();
        }
    }
}