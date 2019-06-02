using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzaBoxTest
{
    [TestClass]
    public class TestSubtotal
    {
        [TestMethod]
        public void TestMethod1()
        {
            PizzaBoxDomain.Pizza p1 = new PizzaBoxDomain.Pizza();

            p1.Size = "Small";
            p1.Crust = "Thin";
            p1.Topping1 = "Pepperoni";
            p1.Topping2 = "Sausage";
            p1.Qty = 4;

            decimal expectedsubtotal1 = 26.00M;
            decimal actualsubtotal1 = p1.CalculateSubtotal();

            Assert.AreEqual(expectedsubtotal1, actualsubtotal1);

            PizzaBoxDomain.Pizza p2 = new PizzaBoxDomain.Pizza();

            p2.Size = "Large";
            p2.Crust = "Stuffed";
            p2.Topping1 = "Pepperoni";
            p2.Topping2 = "Sausage";
            p2.Topping3 = "Bacon";
            p2.Topping4 = "";
            p2.Topping5 = null;
            p2.Qty = 17;

            decimal expectedsubtotal2 = 216.75M;
            decimal actualsubtotal2 = p2.CalculateSubtotal();

            Assert.AreEqual(expectedsubtotal2, actualsubtotal2);
        }
    }
}
