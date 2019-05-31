using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PizzaBoxClient.Models;
using PizzaBoxDomain;

namespace PizzaBoxClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository db;

        Models.StoreInform info;
        List<Models.StoreInform> storelist = new List<Models.StoreInform>();
        Models.OrderHistory orders;
        List<Models.OrderHistory> orderhistorylist = new List<Models.OrderHistory>();
        Models.OrderModel om;

        Pizza pizza;

        public HomeController(IRepository db)
        {
            this.db = db;
        }
        public ActionResult Locations(Customer cust)
        {

            storelist = new List<Models.StoreInform>();
            var stores = db.GetStores();
            foreach (var i in stores) //mapping
            {
                info = new Models.StoreInform();
                info.Add1 = i.Add1;
                info.Add2 = i.Add2;
                info.City = i.City;
                info.State = i.State;
                info.Country = i.Country;
                info.ZipCode = i.ZipCode;
                storelist.Add(info);
            }
            return View(storelist);
        }


        public IActionResult ViewRestaurantData()
        {
            return View();
        }

        public ActionResult PlaceOrder()
        {
            om = new OrderModel();
            return View();
        }

        [HttpPost]
        public ActionResult PlaceOrder(Models.OrderModel ordermodel)
        {
            pizza = new Pizza();

            pizza.CustID = TempData["custID"] as string;
            TempData.Keep();

            pizza.Size = ordermodel.Size;
            pizza.Crust = ordermodel.Crust;
            pizza.Topping1 = ordermodel.Topping1;
            pizza.Topping2 = ordermodel.Topping2;
            pizza.Topping3 = ordermodel.Topping3;
            pizza.Topping4 = ordermodel.Topping4;
            pizza.Topping5 = ordermodel.Topping5;
            pizza.Qty = ordermodel.Qty;

            pizza.Subtotal = pizza.CalculateSubtotal();

            try 
            {
                pizza.Date = DateTime.UtcNow.ToLocalTime().Date;
                pizza.Time = DateTime.UtcNow.ToLocalTime().TimeOfDay;
                db.AddOrder(pizza);
                db.Save();

                return RedirectToAction("Locations");
            }
            catch
            {
                //error to fix
                //SqlException: The INSERT statement conflicted with the FOREIGN KEY constraint "FK_Order_Customer_ID". 
                //The conflict occurred in database "PizzaBoxDB", table "dbo.CustomerAccountInfo", column 'CustomerID'.
                ViewData["Text"] = "Could not submit order.";
                return View();
            }

        }

        /*public IActionResult ConfirmOrder()
        {
            
            return View(pizza);
        }*/

        public ActionResult RedirectToViewOrders()
        {
            return RedirectToAction("ViewOrders", "Home");
        }

        public ActionResult SendOrderToDB()
        {
            return View();
        }

        public ActionResult ViewOrders(Customer cust)
        {
            var o = db.GetOrders();

            string custID = TempData["custid"] as string;
            TempData.Keep();

            foreach (var i in o)
            {
                if (i.CustID == custID)
                {
                    orders = new Models.OrderHistory();
                    orders.OrderID = i.OrderID;
                    orders.Size = i.Size;
                    orders.Crust = i.Crust;
                    orders.Topping1 = i.Topping1;
                    orders.Topping2 = i.Topping2;
                    orders.Topping3 = i.Topping3;
                    orders.Topping4 = i.Topping4;
                    orders.Topping5 = i.Topping5;
                    orders.Qty = i.Qty;
                    orders.Subtotal = i.Subtotal;
                    orders.TimePlaced = i.Time;
                    orders.DatePlaced = i.Date;
                    orderhistorylist.Add(orders);
                }
            }
            return View(orderhistorylist);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
