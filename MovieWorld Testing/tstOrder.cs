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
        public void OrderNoPropertyOk()
        {
            clsOrder Anorder = new clsOrder();
            int TestData = 1;

            Anorder.OrderNo = TestData;
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
            int TestData = 1;

            Anorder.Customer_Id = TestData;
            Assert.AreEqual(Anorder.Customer_Id, TestData);

        }
        [TestMethod]
        public void TotalCostPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            decimal TestData = 5.50;

            AnOrder.TotalCost = TestData;
            Assert.AreEqual(ACustomer.TotalCost, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;

            AnOrder.Staff_Id = TestData;
            Assert.AreEqual(ACustomer.Staff_Id, TestData);
        }
        [TestMethod]
        public void AvailableSeatsPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            bool TestData = true;

            AnOrder.AvailableSeats = TestData;
            Assert.AreEqual(ACustomer.AvailableSeats, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;

            int OrderNo = 1;

            Found = AnOrder.Find(OrderNum);
            Assert.IsTrue(Found);
        }

    }
}
