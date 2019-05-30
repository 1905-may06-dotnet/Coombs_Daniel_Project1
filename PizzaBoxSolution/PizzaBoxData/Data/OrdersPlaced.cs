using System;
using System.Collections.Generic;

namespace PizzaBoxData.Data
{
    public partial class OrdersPlaced
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreId { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Topping1 { get; set; }
        public string Topping2 { get; set; }
        public string Topping3 { get; set; }
        public string Topping4 { get; set; }
        public string Topping5 { get; set; }
        public decimal? Subtotal { get; set; }
        public TimeSpan Timeplaced { get; set; }
        public DateTime Dateplaced { get; set; }
        public int? Qty { get; set; }

        public virtual CustomerAccountInfo Customer { get; set; }
        public virtual StoreInfo Store { get; set; }
    }
}
