using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAcess.Entitites;
using DataAcess.Interfaces;

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

        public async Task<ActionResult> StoreProducts(int storeId)
        {
            List<Product> storeEntitites = await Task.Run(() => _manageService.GetProductsByStoreId(storeId).ToList());
            return View();
        }
    }
}