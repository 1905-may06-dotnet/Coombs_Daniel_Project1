using System;
using System.Collections.Generic;

namespace PizzaBoxData.Data
{
    public partial class CustomerAccountInfo
    {
        public CustomerAccountInfo()
        {
            OrdersPlaced = new HashSet<OrdersPlaced>();
        }

        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<OrdersPlaced> OrdersPlaced { get; set; }
    }
}
