using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DataAcess.Entitites;
using DataAcess.Interfaces;
using BusinessLogic.Services;

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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}