// Unit test 
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void Test_payBill()
        {
            Order o = new Order(1, "Plain", 2, 6);

            double result = o.pay_bill();

            Assert.AreEqual(12, result);
        }
    }
}