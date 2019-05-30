using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxDomain
{
    public interface IRepository
    {
        IEnumerable<Customer> GetCustomers();

        Customer GetCustomerByID(int ID);
        Customer GetCustomerByUser(string user);

        void AddCustomer(Customer customer);


        IEnumerable<Pizza> GetOrders();

        Pizza GetPizzaByID(int ID);
        void AddOrder(Pizza pizza);

        IEnumerable<StoreInformation> GetStores();

        IEnumerable<StoreInv> GetInventory();

        void Save();
    }
}
