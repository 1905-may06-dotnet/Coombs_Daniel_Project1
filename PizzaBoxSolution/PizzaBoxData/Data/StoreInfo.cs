using System;
using System.Collections.Generic;

namespace PizzaBoxData.Data
{
    public partial class StoreInfo
    {
        public StoreInfo()
        {
            OrdersPlaced = new HashSet<OrdersPlaced>();
            StoreInventory = new HashSet<StoreInventory>();
        }

        public int StoreId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }

        public virtual ICollection<OrdersPlaced> OrdersPlaced { get; set; }
        public virtual ICollection<StoreInventory> StoreInventory { get; set; }
    }
}
