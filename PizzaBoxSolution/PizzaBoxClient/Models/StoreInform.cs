using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxClient.Models
{
    public class StoreInform
    {

        public List<StoreInform> StoreList { get; set; }

        [DisplayName("Address 1")]
        public string Add1 { get; set; }
        [DisplayName("Address 2")]
        public string Add2 { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
        [DisplayName("State")]
        public string State { get; set; }
        [DisplayName("Country")]
        public string Country { get; set; }
        [DisplayName("Zip Code")]
        public string ZipCode { get; set; }
    }
}
