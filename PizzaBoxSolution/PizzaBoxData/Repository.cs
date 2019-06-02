using Microsoft.EntityFrameworkCore;
using PizzaBoxData.Data;
using PizzaBoxDomain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBoxData
{
    public class Repository : IRepository
    {
        private readonly PizzaBoxContext _db;

        public Repository(PizzaBoxContext db)
        {
            _db = db;
        }

        public void AddCustomer(PizzaBoxDomain.Customer customer)
        {
            _db.CustomerAccountInfo.Add(Mapper.Map(customer));
        }

        public void AddOrder(Pizza pizza)
        {
            _db.OrdersPlaced.Add(Mapper.Map(pizza));
        }

        public Customer GetCustomerByID(int ID)
        {
            var cust = _db.CustomerAccountInfo.Where(c => c.CustomerId == ID).FirstOrDefault();
            return Mapper.Map(cust);
        }

        public Customer GetCustomerByUser(string user)
        {
            var cust = _db.CustomerAccountInfo.Where(c => c.Username == user).FirstOrDefault();
            return Mapper.Map(cust);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _db.CustomerAccountInfo.Select(c => Mapper.Map(c));
        }

        public IEnumerable<Pizza> GetOrders()
        {
            return _db.OrdersPlaced.Select(o => Mapper.Map(o));
        }

        public Pizza GetOrdersByRestaurant(int ID)
        {
            var orders = _db.OrdersPlaced.Where(o => o.StoreId == ID).FirstOrDefault();
            return Mapper.Map(orders);
        }

        public Pizza GetPizzaByID(string ID)
        {
            var pizza = _db.OrdersPlaced.Where(o => o.OrderId == Convert.ToInt32(ID)).FirstOrDefault();
            return Mapper.Map(pizza);
        }

        public IEnumerable<StoreInformation> GetStores()
        {
            return _db.StoreInfo.Select(s => Mapper.Map(s));
        }

        public IEnumerable<StoreInv> GetInventory()
        {
            return _db.StoreInventory.Select(s => Mapper.Map(s));
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
