using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBoxClient.Models
{
    public class CustomerModel
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(20, ErrorMessage = "Limit first name to at most 20 characters.")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage ="Last name is required.")]
        [StringLength(20,ErrorMessage ="Limit last name to at most 20 characters.")]
        public string LastName { get; set; }
        [DisplayName("Address 1")]
        [Required(ErrorMessage = "Address 1 is required.")]
        [StringLength(40, ErrorMessage = "Limit address 1 to at most 40 characters.")]
        public string Add1 { get; set; }
        [DisplayName("Address 2")]
        [StringLength(40, ErrorMessage = "Limit address 2 to at most 40 characters.")]
        public string Add2 { get; set; }
        [DisplayName("City")]
        [Required(ErrorMessage = "City is required.")]
        [StringLength(20, ErrorMessage = "Limit city to at most 20 characters.")]
        public string City { get; set; }
        [DisplayName("State Abbreviation")]
        [Required(ErrorMessage = "State abbreviation is required.")]
        [StringLength(5, ErrorMessage = "Limit state to at most 5 characters.")]
        public string State { get; set; }
        [DisplayName("Country")]
        [Required(ErrorMessage = "Country is required.")]
        [StringLength(20, ErrorMessage = "Limit country to at most 20 characters.")]
        public string Country { get; set; }
        [DisplayName("Zip Code")]
        [Required(ErrorMessage = "Zip code is required.")]
        [StringLength(10, ErrorMessage = "Limit zip code to at most 10 characters.")]
        public string ZipCode { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(32, ErrorMessage = "Limit username to at most 32 characters.")]
        public string Username { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(32, ErrorMessage = "Limit password to at most 32 characters.")]
        public string Password { get; set; }
        [DisplayName("Re-Enter Password")]
        [Required(ErrorMessage ="Please re-enter your password.")]
        public string ReEnterPassword { get; set; }

        public string custID { get; set; }
    }
}
