using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxDomain
{
    public class Pizza
    {
        private string orderID;
        private string custID;
        private int location;

        private string size;
        private string crust;
        private List<string> toppings;
        private string topping1, topping2, topping3, topping4, topping5;

        private decimal subtotal;

        private TimeSpan time;
        private DateTime date;

        private int qty = 0;

        public string OrderID { get { return orderID; } set { orderID = value; } }
        public string CustID { get { return custID; } set { custID = value; } }
        public int Location { get { return location; } set { location = value; } }

        public string Size { get { return size; } set { size = value; } }
        public string Crust { get { return crust; } set { crust = value; } }
        public List<string> Toppings { get; set; } = new List<string>();

        public string Topping1 { get { return topping1; } set { topping1 = value; } }
        public string Topping2 { get { return topping2; } set { topping2 = value; } }
        public string Topping3 { get { return topping3; } set { topping3 = value; } }
        public string Topping4 { get { return topping4; } set { topping4 = value; } }
        public string Topping5 { get { return topping5; } set { topping5 = value; } }

        public decimal Subtotal { get { return subtotal; } set { subtotal = value; } }

        public TimeSpan Time { get { return time; } set { time = value; } }
        public DateTime Date { get { return date; } set { date = value; } }

        public int Qty { get { return qty; } set { qty = value; } }

        public decimal CalculateSubtotal()
        {
            subtotal = 0.00M;
            if (Size == "Small") subtotal += 5.00M;
            else if (Size == "Medium") subtotal += 7.00M;
            else if (Size == "Large") subtotal += 9.00M;
            else if (Size == "ExtraLarge" || Size == "Extra Large") subtotal += 11.00M;
            else { }

            if (Crust == "Pan" || Crust == "Thick") subtotal += 0.50M;
            else if (Crust == "Stuffed") subtotal += 1.50M;
            else { }

            if (Topping1 != null && Topping1 != "" && Topping1 != "None") subtotal += 0.75M;
            if (Topping2 != null && Topping2 != "" && Topping2 != "None") subtotal += 0.75M;
            if (Topping3 != null && Topping3 != "" && Topping3 != "None") subtotal += 0.75M;
            if (Topping4 != null && Topping4 != "" && Topping4 != "None") subtotal += 0.75M;
            if (Topping5 != null && Topping5 != "" && Topping5 != "None") subtotal += 0.75M;

            return subtotal;
        }
    }
}
