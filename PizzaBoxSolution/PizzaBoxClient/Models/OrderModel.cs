using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxClient.Models
{
    public class OrderModel
    {
        public int Location { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Topping1 { get; set; }
        public string Topping2 { get; set; }
        public string Topping3 { get; set; }
        public string Topping4 { get; set; }
        public string Topping5 { get; set; }

        [Required(ErrorMessage="Please select a quantity.")]
        public int Qty { get; set; }

        public List<string> SizeList = new List<string>() { "Small", "Medium", "Large", "Extra Large"};
        public List<string> CrustList = new List<string>() { "Hand Tossed", "Thin", "Pan", "Thick", "Stuffed" };
        public List<string> ToppingsList = new List<string>() { "Pepperoni", "Sausage", "Bacon", "Pineapple", "Mushrooms", "Onions", "Extra Cheese", "Olives" };

    }
}
