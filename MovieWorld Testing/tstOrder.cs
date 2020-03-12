﻿using System;
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
        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIdFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.Customer_Id != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateOfOrderFound()
        {

            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.DateOfOrder != Convert.ToDateTime("05/05/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Staff_IdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.StaffId != 1)
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
            if (AnOrder.TotalCost != 1)
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
            ClsOrder Anorder = new clsOrder();
            String Error = "";
            String OrderNo = "";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
        public void OrderNoMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderNo = "";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder):
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
            OrderNo = OrderNo.padRight(500, 'a');
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
  
         [TestMethod]
        public void DateOfOrderExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate.AddYears(-100);
            String DateOfOrder = tesrtDate.toString();
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

        [TestMethod]
        public void DateOfOrderMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateOfOrder = TestDate.ToString();
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderMin()
        {

            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOfOrder = TestDate.ToString();
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfOrderMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateOfOrder = TestDate.ToString();
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
             String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateOfOrder = TestDate.ToString();

            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
             Assert.AreNotEqual(Error, "");
        }
        public Void DateOfOrderInvalidData()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            String DateOfOrder = "This is not a date";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }

        public void Staff_IdMinLessOne()
        {
            ClsOrder Anorder = new clsOrder();
            String Error = "";
            String Staff_Id = "";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
        public void Staff_IdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String Staff_Id = "";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder):
    Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_IdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "aa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_IdMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "aaaaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Staff_IdMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "aaaaaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_IdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "aaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Staff_IdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "aaaaaaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_IdExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "aaaaaaa";
            Staff_Id = Staff_Id.padRight(100, 'a');
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        public void Customer_IdMinLessOne()
        {
            ClsOrder Anorder = new clsOrder();
            String Error = "";
            String Customer_Id = "";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreNotEqual(Error,"");
        }
        public void Customer_IdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String Customer_Id = "";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder):
    Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_IdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Customer_Id = "aa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_IdMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Customer_Id = "aaaaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Customer_IdMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Customer_Id = "aaaaaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_IdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Customer_Id = "aaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Customer_IdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Customer_Id = "aaaaaaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_IdExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Customer_Id = "aaaaaaa";
            Customer_Id = Customer_Id.padRight(500, 'a');
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, AvailableSeats, DateOfOrder);
            Assert.AreEqual(Error, "");
        }


    }
}
