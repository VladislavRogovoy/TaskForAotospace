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

        public HomeController()
        {
        }

        public HomeController(IRepository<Store> storeRepository)
        {
            _storeService = new StoreService(storeRepository);
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