using System;
using Class_Library;
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
            string TestData = "1";

            Anorder.OrderNo = TestData;
            Assert.AreEqual(Anorder.OrderNo, TestData);
        }
        [TestMethod]
        public void DateOfOrderPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;

            AnOrder.DateOfOrder = TestData;
            Assert.AreEqual(AnOrder.DateOfOrder, TestData);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "ubay";

            AnOrder.Customer_Id = TestData;
            Assert.AreEqual(AnOrder.Customer_Id, TestData);

        }
        [TestMethod]
        public void TotalCostPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "5.50";

            AnOrder.TotalCost = TestData;
            Assert.AreEqual(AnOrder.TotalCost, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "1";

            AnOrder.Staff_Id = TestData;
            Assert.AreEqual(AnOrder.Staff_Id, TestData);
        }
        [TestMethod]
        public void AvailableSeatsPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            bool TestData = true;

            AnOrder.AvailableSeats = TestData;
            Assert.AreEqual(AnOrder.AvailableSeats, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderNo != "1")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "ubay";
            AnOrder.Customer_Id = TestData;
            Assert.AreEqual(AnOrder.Customer_Id, TestData);
        }
        [TestMethod]
        public void DateOfOrderFound()
        {

            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;

            AnOrder.DateOfOrder = TestData;
            Assert.AreEqual(AnOrder.DateOfOrder, TestData);
        }

        [TestMethod]
        public void Staff_IdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.Staff_Id != "1")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestTotalCostFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.TotalCost != "5.50")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
      
        [TestMethod]
        public void AvailableSeatsFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.AvailableSeats != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderNoMinLessOne()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            String OrderNo = "";
            Error = Anorder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
        public void OrderNoMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderNo = "";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "aa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "aaaaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "aaaaaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "aaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "aaaaaaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "aaaaaaa";
            OrderNo = OrderNo.PadRight(500, 'a');
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date; TestDate.AddYears(-100);
            String DateOfOrder = TestDate.ToString();
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
    }
}
        



