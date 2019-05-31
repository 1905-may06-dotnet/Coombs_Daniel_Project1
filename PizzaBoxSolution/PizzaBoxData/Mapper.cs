using PizzaBoxData.Data;
using PizzaBoxDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxData
{
    public static class Mapper
    {
        public static Customer Map(CustomerAccountInfo cust) => new Customer
        {
            FirstName = cust.Firstname,
            LastName = cust.Lastname,
            Add1 = cust.Address1,
            Add2 = cust.Address2,
            City = cust.City,
            State = cust.State,
            Country = cust.Country,
            ZipCode = cust.Zipcode,
            Username = cust.Username,
            Password = cust.Password,
            CustID = Convert.ToString(cust.CustomerId)
        };

        public static CustomerAccountInfo Map(Customer cust) => new CustomerAccountInfo
        {
            Firstname = cust.FirstName,
            Lastname = cust.LastName,
            Address1 = cust.Add1,
            Address2 = cust.Add2,
            City = cust.City,
            State = cust.State,
            Country = cust.Country,
            Zipcode = cust.ZipCode,
            Username = cust.Username,
            Password = cust.Password
        };

        public static Pizza Map(OrdersPlaced order) => new Pizza
        {
            OrderID = Convert.ToString(order.OrderId),
            CustID = Convert.ToString(order.CustomerId),
            Location = Convert.ToInt32(order.StoreId),
            Size = order.Size,
            Crust = order.Crust,
            Topping1 = order.Topping1,
            Topping2 = order.Topping2,
            Topping3 = order.Topping3,
            Topping4 = order.Topping4,
            Topping5 = order.Topping5,
            Subtotal = Convert.ToDecimal(order.Subtotal),
            Time = order.Timeplaced,
            Date = order.Dateplaced,
            Qty = Convert.ToInt32(order.Qty)
        };

        public static OrdersPlaced Map(Pizza order) => new OrdersPlaced
        {
            CustomerId = Convert.ToInt32(order.OrderID),
            StoreId = order.Location,
            Size = order.Size,
            Crust = order.Crust,
            Topping1 = order.Topping1,
            Topping2 = order.Topping2,
            Topping3 = order.Topping3,
            Topping4 = order.Topping4,
            Topping5 = order.Topping5,
            Subtotal = order.Subtotal,
            Timeplaced = order.Time,
            Dateplaced = order.Date,
            Qty = order.Qty
        };

        public static StoreInformation Map(StoreInfo info) => new StoreInformation
        {
            StoreLocation = info.StoreId,
            Add1 = info.Address1,
            Add2 = info.Address2,
            City = info.City,
            State = info.State,
            Country = info.Country,
            ZipCode = info.Zipcode
        };

        public static StoreInfo Map(StoreInformation info) => new StoreInfo
        {
            Address1 = info.Add1,
            Address2 = info.Add2,
            City = info.City,
            State = info.State,
            Country = info.Country,
            Zipcode = info.ZipCode
        };

        public static StoreInv Map(StoreInventory inv) => new StoreInv
        {
            InvId = inv.InventoryId,
            InvLocation = Convert.ToInt32(inv.StoreId),
            DoughQty = Convert.ToInt32(inv.Dough),
            CheeseQty = Convert.ToInt32(inv.Cheese),
            SauceQty = Convert.ToInt32(inv.Sauce),
            PepperoniQty = Convert.ToInt32(inv.Pepperoni),
            SausageQty = Convert.ToInt32(inv.Sausage),
            BaconQty = Convert.ToInt32(inv.Bacon),
            PineappleQty = Convert.ToInt32(inv.Pineapple),
            MushroomQty = Convert.ToInt32(inv.Mushroom),
            OnionQty = Convert.ToInt32(inv.Onion),
            OliveQty = Convert.ToInt32(inv.Olive)
        };

        public static StoreInventory Map(StoreInv inv) => new StoreInventory
        {
            InventoryId = inv.InvId,
            StoreId = inv.InvLocation,
            Dough = inv.DoughQty,
            Cheese = inv.CheeseQty,
            Sauce = inv.SauceQty,
            Pepperoni = inv.PepperoniQty,
            Sausage = inv.SausageQty,
            Bacon = inv.BaconQty,
            Pineapple = inv.PineappleQty,
            Mushroom = inv.MushroomQty,
            Onion = inv.OnionQty,
            Olive = inv.OliveQty
        };
    }
}
