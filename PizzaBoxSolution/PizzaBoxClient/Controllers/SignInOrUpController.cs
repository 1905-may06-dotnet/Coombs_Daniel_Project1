using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaBoxData;
using PizzaBoxDomain;

namespace PizzaBoxClient.Controllers
{
    public class SignInOrUpController : Controller
    {
        private readonly IRepository db;

        Models.CustomerModel cust = new Models.CustomerModel();
        List<Models.CustomerModel> custlist = new List<Models.CustomerModel>();

        Pizza p = new Pizza();
        Customer c = new Customer();

        public SignInOrUpController(IRepository db)
        {
            this.db = db;
        }
        // GET: SignInOrUp
        public ActionResult LogIn()
        {
            TempData["custid"] = "-1";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(IFormCollection collection, Models.CustomerModel cust)
        {
            
            var customer = db.GetCustomers();
            foreach (var i in customer)
            {
                if (i.Username == cust.Username)
                {
                    if (i.Password == cust.Password)
                    {
                        var user = db.GetCustomerByUser(i.Username);
                        c.Username = i.Username;
                        c.Password = i.Password;

                        c.FirstName = i.FirstName;
                        c.LastName = i.LastName;
                        c.Add1 = i.Add1;
                        c.Add2 = i.Add2;
                        c.City = i.City;
                        c.State = i.State;
                        c.Country = i.Country;
                        c.ZipCode = i.ZipCode;

                        c.CustID = i.CustID;

                        TempData["custid"] = c.CustID;

                        return RedirectToAction("Locations", "Home");
                    }
                    ViewData["Text"] = "Incorrect Password.";
                    return View();
                }
            }

            ViewData["Text"] = "Username does not exist.";
            return View();
        }

        // G: SignInOrUp/Create
        public ActionResult CreateAccount()
        {
            return View();
        }

        // POST: SignInOrUp/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAccount(IFormCollection collection, Models.CustomerModel cust)
        {
            Customer c = new Customer();
            bool usernametaken = false;

            var customers = db.GetCustomers();

            foreach (var i in customers)
            {
                if (i.Username == cust.Username)
                {
                    usernametaken = true;
                }
            }
            if (usernametaken == true)
            {
                ViewData["Text"] = "Username is taken.";
                return View(); //include error catcher
            }
            else
            {
                c.Username = cust.Username;
            }
            if (c.MatchPassword(cust.Password, cust.ReEnterPassword) == true)
            {
                c.Password = cust.Password;
            }
            else
            {
                ViewData["Text"] = "Passwords do not match.";
                return View(); //include error catcher
            }

            c.FirstName = cust.FirstName;
            c.LastName = cust.LastName;
            c.Add1 = cust.Add1;
            c.Add2 = cust.Add2;
            c.City = cust.City;
            c.State = cust.State;
            c.Country = cust.Country;
            c.ZipCode = cust.ZipCode;

            try
            {
                db.AddCustomer(c);
                db.Save();
                c.CustID = db.GetCustomerByUser(cust.Username).CustID;
                TempData["custid"] = c.CustID;
                return RedirectToAction("Locations", "Home");
            }
            catch
            {
                return LogIn();
            }
        }
    }
}