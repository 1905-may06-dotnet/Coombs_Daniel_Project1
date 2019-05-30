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

        private decimal subtotal;
        private decimal holdsubtotal;

        private TimeSpan time;
        private DateTime date;

        private int qtyremaining = 100;
        private int holdqtyremaining = 100;
        private int qty = 0;
        private int numofpizzaingroup;

        public string OrderID { get; set; }
        public string CustID { get; set; }
        public int Location { get; set; }

        public string Size { get; set; }
        public string Crust { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();
        
        public decimal Subtotal { get; set; }
        public decimal HoldSubtotal { get; set; }

        public TimeSpan Time { get; set; }
        public DateTime Date { get; set; }

        public int QtyRemaining { get; }
        public int HoldQtyRemaining { get; }
        public int Qty { get; set; }
        public int NumOfPizzaInGroup { get; set; }
    }
}
