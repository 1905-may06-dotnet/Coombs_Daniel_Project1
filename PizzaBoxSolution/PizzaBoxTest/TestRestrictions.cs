using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaBoxDomain;
using System;

namespace PizzaBoxTest
{
    [TestClass]
    public class TestRestrictions
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pizza p = new Pizza();

            p.Subtotal = 1100.00M; //ACTUAL LIMIT is $5000, BUT IT'S BEEN MODIFIED TO $1000 TO MATCH CURRENT PRICES (max: $1,625)

            Assert.IsFalse(p.CheckIfOverAmount());

            p.Subtotal = 1000.00M;

            Assert.IsTrue(p.CheckIfOverAmount());

            p.Subtotal = 900.00M;

            Assert.IsTrue(p.CheckIfOverAmount());
        }
/*
        [TestMethod]
        public void TestMethod2() //test eligiblity for 2 hours after placing order
        {
            Pizza p = new Pizza();
            p.Location = 1;
            
            /*
             * Please set system time to 3:00 P.M.
             * Please set system date to June 2, 2019
             */
            p.Time = new TimeSpan(14, 00, 00);
            p.Date = new DateTime(2019, 6, 2);

            Assert.IsFalse(p.CheckIfEligible2Hours(p.Time, p.Date));

            p.Time = new TimeSpan(12, 00, 00);

            Assert.IsTrue(p.CheckIfEligible2Hours(p.Time, p.Date));

            p.Time = new TimeSpan(14, 00, 00);
            p.Date = new DateTime(2019, 6, 1);

            Assert.IsTrue(p.CheckIfEligible2Hours(p.Time, p.Date));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Pizza p = new Pizza();

            /*
             * Please set system time to 3:00 P.M.
             * Please set system date to June 2, 2019
            */

            p.Location = 1;
            p.Date = new DateTime(2019, 6, 2);

            Assert.IsFalse(p.CheckIfEligibleSameDay(p.Date, 2));
            Assert.IsTrue(p.CheckIfEligibleSameDay(p.Date, 1));

            p.Date = new DateTime(2019, 6, 1);

            Assert.IsTrue(p.CheckIfEligibleSameDay(p.Date, 2));
        }*/
    }
}
