using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxClient.Models
{
    public class OrderHistory
    {
        public string OrderID { get; set; }
        
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Topping1 { get; set; }
        public string Topping2 { get; set; }
        public string Topping3 { get; set; }
        public string Topping4 { get; set; }
        public string Topping5 { get; set; }
        public int Qty { get; set; }
        public decimal Subtotal { get; set; }

        public TimeSpan TimePlaced { get; set; }

        public DateTime DatePlaced { get; set; }

        public int Location { get; set; }

        public int Data { get; set; }

        public string LocString { get { return LocationToString(Location); } }

        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }

        public string LocationToString(int loc)
        {
            switch (loc)
            {
                case 1: return "Arlington";
                case 2: return "Dallas";
                case 3: return "Fort Worth";
                case 4: return "Houston";
                default: return "Austin";
            }
        }
    }
}
