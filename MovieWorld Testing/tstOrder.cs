using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWorldClasses;

namespace MovieWorld_Testing
{
    [TestClass]
    public class TstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {

            clsOrder Anorder = new clsOrder();
            Assert.IsNotNull(Anorder);
        }
        [TestMethod]
        public void OrderIdPropertyOk()
        {
            clsOrder Anorder = new clsOrder();
            int TestData = 1;

            Anorder.Order_id = TestData;
            Assert.AreEqual(Anorder.Order_id, TestData);
        }
        [TestMethod]
        public void DateOfOrderPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;

            AnOrder.create_date = TestData;
            Assert.AreEqual(AnOrder.create_date, TestData);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsOrder Anorder = new clsOrder();
            string TestData = "Joe";

            Anorder.Customer_Id = TestData;
            Assert.AreEqual(Anorder.Customer_Id, TestData);

        }
    }
}
