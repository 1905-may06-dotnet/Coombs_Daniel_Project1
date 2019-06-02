using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxDomain
{
    public class StoreInformation
    {
        private int storelocation;
        private string add1;
        private string add2;
        private string city;
        private string state;
        private string country;
        private string zipcode;
        
        public int StoreLocation { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
