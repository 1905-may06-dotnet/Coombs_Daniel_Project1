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

        public string ConvertStoreIDToName(int num)
        {
            if (num == 1) return "Arlington";
            else if (num == 2) return "Dallas";
            else if (num == 3) return "Fort Worth";
            else if (num == 4) return "Houston";
            else return "Austin";
        }
        
        public int ConvertStringNameToID(string name)
        {
            if (name == "Arlington") return 1;
            else if (name == "Dallas") return 2;
            else if (name == "Fort Worth" || name == "FortWorth") return 3;
            else if (name == "Houston") return 4;
            else return 5;
        }
    }
}
