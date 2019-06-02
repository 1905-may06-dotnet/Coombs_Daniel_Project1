using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBoxDomain
{
    public class Customer
    {
        private string _firstname;
        private string _lastname;
        private string _add1;
        private string _add2;
        private string _city;
        private string _state;
        private string _country;
        private string _zipcode;

        private string _username;
        private string _password;
        private string _custID = "-1";

        public string FirstName { get { return _firstname; } set { _firstname = value; } }
        public string LastName { get { return _lastname; } set { _lastname = value; } }
        public string Add1  { get { return _add1; } set { _add1 = value; } } 
        public string Add2 { get { return _add2; } set { _add2 = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public string State { get { return _state; } set { _state = value; } }
        public string Country { get { return _country; } set { _country = value; } }
        public string ZipCode { get { return _zipcode; } set { _zipcode = value; } }

        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string CustID { get { return _custID; } set { _custID = value; } }

        public bool MatchPassword(string pass1, string pass2)
        {
            if (pass1 == pass2)
            {
                return true;
            }
            return false;
        }
    }
}
