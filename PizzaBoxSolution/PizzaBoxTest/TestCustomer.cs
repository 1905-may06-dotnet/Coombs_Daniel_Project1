using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaBoxDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBoxTest
{
    [TestClass]
    public class TestCustomer
    {
        [TestMethod]
        public void TestCustomerMethod()
        {
            Customer c = new Customer();

            string password1 = "test";
            string password2 = "test";
            string password3 = "Test";
            string password4 = "inCorrect";

            Assert.IsTrue(c.MatchPassword(password1, password2));
            Assert.IsFalse(c.MatchPassword(password1, password3));
            Assert.IsFalse(c.MatchPassword(password2, password4));
        }
    }
}
