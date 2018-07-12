using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using signadmin.Models;
using MySql;


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
            var items = _appDbContext.Item;
            
            foreach(var  item in items) {
                Console.WriteLine(item.Name);
            }
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
