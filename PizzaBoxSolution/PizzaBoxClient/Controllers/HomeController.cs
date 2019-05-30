using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBoxClient.Models;
using PizzaBoxDomain;

namespace PizzaBoxClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository db;

        public HomeController(IRepository db)
        {
            this.db = db;
        }
        public IActionResult Locations()
        {
            return View();
        }


        public IActionResult ViewRestaurantData()
        {
            return View();
        }

        public IActionResult PlaceOrder()
        {
            return View();
        }

        public IActionResult ViewOrders()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
