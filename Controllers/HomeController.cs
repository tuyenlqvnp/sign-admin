﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sign_admin.Models;

namespace sign_admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public  HomeController() {
            _dbContext = new AppDbContext();
        }

        public IActionResult Index()
        {
            var customers = _dbContext.Customer;
            foreach(var  customer in customers) {
                Console.WriteLine(customer.Name);
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
