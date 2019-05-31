using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxClient.Models
{
    public class OrderHistory
    {
        public List<string> Locations = new List<string>() { "Arlington", "Dallas", "Fort Worth", "Houston", "Austin" };

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


    }
}
