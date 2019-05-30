using System;
using System.Collections.Generic;

namespace PizzaBoxData.Data
{
    public partial class StoreInventory
    {
        public int InventoryId { get; set; }
        public int? StoreId { get; set; }
        public int? Dough { get; set; }
        public int? Cheese { get; set; }
        public int? Sauce { get; set; }
        public int? Pepperoni { get; set; }
        public int? Sausage { get; set; }
        public int? Bacon { get; set; }
        public int? Pineapple { get; set; }
        public int? Mushroom { get; set; }
        public int? Onion { get; set; }
        public int? Olive { get; set; }

        public virtual StoreInfo Store { get; set; }
    }
}
