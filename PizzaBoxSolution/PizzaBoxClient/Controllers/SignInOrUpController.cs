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

        public SignInOrUpController(IRepository db)
        {
            this.db = db;
        }
        // GET: SignInOrUp
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(IFormCollection collection, Models.CustomerModel cust)
        {
            Customer c = new Customer();
            var customer = db.GetCustomerByUser(cust.Username);

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
                ViewBag.Message = "Username is taken. Please choose a different username.";
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
                ViewBag.Message = "Passwords do not match. Please make sure your passwords match.";
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
                return RedirectToAction(nameof(LogIn));
                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                return LogIn();
            }
        }
    }
}