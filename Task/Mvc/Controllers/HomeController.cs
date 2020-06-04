using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using BusinessLogic.Interfaces;
using DataAcess.Entitites;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IManageService _manageService;

        public HomeController()
        {
        }

        public HomeController(IManageService manageService)
        {
            _manageService = manageService;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            List<Store> storeEntitites = await Task.Run(() => _manageService.GetAllStores().ToList());
            ViewBag.StoreEntities = storeEntitites;
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> StoreProducts(int storeId)
        {
            List<Product> productEntities = await Task.Run(() => _manageService.GetProductsByStoreId(storeId).ToList());
            ViewBag.ProductEntities = productEntities;
            return View();
        }
    }
}