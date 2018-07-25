using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using signadmin.Models;
using signadmin.DAO;


namespace signadmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public  HomeController(AppDbContext appDbContext) {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            ItemDAO dao = new ItemDAO(this._appDbContext);
            List<Item> list = dao.GetList(new ItemFilterCriterio(), 1, 10);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
