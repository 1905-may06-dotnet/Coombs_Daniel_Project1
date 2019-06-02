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

        Models.CustomerModel cust;
        List<Models.CustomerModel> custlist = new List<CustomerModel>();

        Models.Inventory inv;
        List<Models.Inventory> invlist = new List<Models.Inventory>();

        Pizza pizza;

        public HomeController(IRepository db)
        {
            this.db = db;
        }
        public ActionResult Locations()
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

        public ActionResult PlaceOrder()
        {
            om = new OrderModel(); //test to see if necessary
            return View();
        }

        [HttpPost]
        public ActionResult PlaceOrder(IFormCollection collection, Models.OrderModel ordermodel)
        {
            try
            {
                var or = db.GetOrders();

                pizza = new Pizza();

                pizza.CustID = TempData["custID"] as string;
                TempData.Keep();

                ordermodel.CustID = TempData["custID"] as string;
                TempData.Keep();

                if (pizza.CustID == "-1")
                {
                    ViewData["text"] = "Please Log In to place your order.";
                    return View();
                }

                pizza.Location = ordermodel.Location;
                pizza.Size = ordermodel.Size;
                pizza.Crust = ordermodel.Crust;
                pizza.Topping1 = ordermodel.Topping1;
                pizza.Topping2 = ordermodel.Topping2;
                pizza.Topping3 = ordermodel.Topping3;
                pizza.Topping4 = ordermodel.Topping4;
                pizza.Topping5 = ordermodel.Topping5;
                pizza.Qty = ordermodel.Qty;

                pizza.Subtotal = pizza.CalculateSubtotal();

                foreach (var i in or)
                {
                    if (pizza.CustID == i.CustID)
                    {
                        if (pizza.CheckIfEligible2Hours(i.Time, i.Date) == false)
                        {
                            ViewData["Text"] = "Please wait 2 hours after ordering to place another order.";
                            return View();
                        }
                        if (pizza.CheckIfEligibleSameDay(i.Date, i.Location) == false)
                        {
                            ViewData["Text"] = "You can only order at one location per day.";
                            return View();
                        }
                    }
                }

                if (pizza.CheckIfOverAmount() == false)
                {
                    ViewData["Text"] = "Your order cannot exceed over $1000.";
                    return View();
                }

                TempData["location"] = pizza.Location;
                TempData["size"] = pizza.Size;
                TempData["crust"] = pizza.Crust;
                TempData["top1"] = pizza.Topping1;
                TempData["top2"] = pizza.Topping2;
                TempData["top3"] = pizza.Topping3;
                TempData["top4"] = pizza.Topping4;
                TempData["top5"] = pizza.Topping5;
                TempData["qty"] = Convert.ToString(pizza.Qty);
                TempData["subtotal"] = Convert.ToString(pizza.Subtotal);

                return RedirectToAction("ConfirmOrder");
            }
            catch
            {
                ViewData["Text"] = "Could not submit order.";
                return View();
            }

        }

        public IActionResult ConfirmOrder() //NOTE: PLEASE FIX TO UTILIZE (PREFERABLY JSON) SERIALIZATION
        {
            ViewBag.OrderToConfirm1 = $"{TempData["qty"] as string} {TempData["size"] as string} {TempData["crust"] as string} Crust Pizza(s) with the following Topping(s)";
            ViewBag.OrderToConfirm2 = $"{TempData["top1"] as string} {TempData["top2"] as string} {TempData["top3"] as string} {TempData["top4"] as string} {TempData["top5"] as string}";
            ViewBag.OrderToConfirm3 = $"${Decimal.Round(Convert.ToDecimal(TempData["subtotal"] as string), 2)}";
            TempData.Keep();
            return View();
        }

        [HttpPost]
        public ActionResult ConfirmOrder(IFormCollection collection, Pizza pizza) //NOTE: PLEASE FIX TO UTILIZE (PREFERABLY JSON) SERIALIZATION
        {
            pizza.CustID = TempData["custid"] as string;
            pizza.Location = (int)TempData["location"];
            pizza.Size = TempData["size"] as string;
            pizza.Crust = TempData["crust"] as string;
            pizza.Topping1 = TempData["top1"] as string;
            pizza.Topping2 = TempData["top2"] as string;
            pizza.Topping3 = TempData["top3"] as string;
            pizza.Topping4 = TempData["top4"] as string;
            pizza.Topping5 = TempData["top5"] as string;
            pizza.Qty = Convert.ToInt32(TempData["qty"]);
            pizza.Subtotal = Convert.ToDecimal(TempData["subtotal"]);

            pizza.Date = DateTime.UtcNow.ToLocalTime().Date;
            pizza.Time = DateTime.UtcNow.ToLocalTime().TimeOfDay;
            db.AddOrder(pizza);
            db.Save();
            ViewBag.OrderSubmitted = "Your order has been submitted.";
            return RedirectToAction("Locations");
        }

        public ActionResult RedirectToViewOrders()
        {
            return RedirectToAction("ViewOrders", "Home");
        }

        public ActionResult ViewOrders()
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

        public ActionResult ViewRestaurantData()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ViewRestaurantData(Models.OrderHistory or)
        {
            TempData["location"] = or.Location;
            if (or.Data == 1)
            {
                return RedirectToAction("ViewRestaurantData_Customers");
            }
            else if (or.Data == 2)
            {
                return RedirectToAction("ViewRestaurantData_OrdersAndSales");
            }
            else
            {
                return RedirectToAction("ViewRestaurantData_Inventory");
            }
        }



        public ActionResult ViewRestaurantData_Customers()
        {
            var o = db.GetOrders();
            var c = db.GetCustomers();

            bool isincluded = false;
            int location = (int)TempData["location"];
            TempData.Keep();

            custlist = new List<CustomerModel>();

            foreach (var i in c)
            {
                isincluded = false;
                foreach (var j in o)
                {
                    if (i.CustID == j.CustID && location == j.Location)
                    {
                        isincluded = true;
                    }
                }

                if (isincluded == true)
                {
                    cust = new Models.CustomerModel();
                    cust.CustID = i.CustID;
                    cust.FirstName = i.FirstName;
                    cust.LastName = i.LastName;
                    cust.Add1 = i.Add1;
                    cust.Add2 = i.Add2;
                    cust.City = i.City;
                    cust.State = i.State;
                    cust.Country = i.Country;
                    cust.ZipCode = i.ZipCode;
                    cust.Username = i.Username;
                    custlist.Add(cust);
                }
            }
            return View(custlist);
        }

        public ActionResult ViewRestaurantData_OrdersAndSales()
        {
            orderhistorylist = new List<Models.OrderHistory>();
            var o = db.GetOrders();

            decimal totalsubtotal = 0.00M;
            int custqty = 0;
            int orderqty = 0;
            int location = (int)TempData["location"];
            TempData.Keep();

            foreach (var i in o)
            {
                if (i.Location == location)
                {
                    custqty++;
                    orders = new OrderHistory();
                    orders.OrderID = i.OrderID;
                    orders.Size = i.Size;
                    orders.Crust = i.Crust;
                    orders.Topping1 = i.Topping1;
                    orders.Topping2 = i.Topping2;
                    orders.Topping3 = i.Topping3;
                    orders.Topping4 = i.Topping4;
                    orders.Topping5 = i.Topping5;
                    orders.Qty = i.Qty;
                    orderqty += i.Qty;
                    orders.Subtotal = i.Subtotal;
                    totalsubtotal += i.Subtotal;
                    orderhistorylist.Add(orders);
                }
            }
            ViewBag.OrdersAndSales = $"Total Orders Placed: {custqty}\n" +
                $"Total Pizzas Ordered: {orderqty}\n" +
                $"Overall Subtotal: ${Decimal.Round(totalsubtotal, 2)}";
            return View(orderhistorylist);
        }

        public ActionResult ViewRestaurantData_Inventory()
        {
            invlist = new List<Models.Inventory>();
            var o = db.GetInventory();
            int location = (int)TempData["location"];
            TempData.Keep();

            foreach(var i in o)
            {
                if (i.InvLocation == location)
                {
                    inv = new Inventory();
                    inv.Dough = i.DoughQty;
                    inv.Sauce = i.SauceQty;
                    inv.Cheese = i.CheeseQty;
                    inv.Pepperoni = i.PepperoniQty;
                    inv.Sausage = i.SausageQty;
                    inv.Bacon = i.BaconQty;
                    inv.Pineapple = i.PineappleQty;
                    inv.Mushroom = i.MushroomQty;
                    inv.Onion = i.OnionQty;
                    inv.Olive = i.OliveQty;
                    invlist.Add(inv);
                }
            }
            return View(invlist);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
