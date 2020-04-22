﻿using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWorldClasses;

namespace MovieWorldTesting
{
    [TestClass]
    public class TstOrder
    {
        
        string DateOfOrder = DateTime.Now.Date.ToString();
        string Customer_Id = "Ubaydullah";
        string Staff_Id = "1";
        string TotalCost = "5.50";
       





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
            int TestData = 0;

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
            Boolean Ok = true;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderNo != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
            
        }

        [TestMethod]
        public void CustomerIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.Customer_Id != "ubay")
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
            if (AnOrder.DateOfOrder != Convert.ToDateTime("05/06/2020"))
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
            if (AnOrder.Staff_Id != "1")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
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
        public void ValidMethodOk()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            Error = AnOrder.Valid(Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
       

        [TestMethod]
        public void DateOfOrderExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOfOrder = TestDate.ToString();
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
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
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
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
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
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
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
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
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfOrderInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DateOfOrder = "This is not a date";
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Customer_IdMinLessOne()
        {
        clsOrder AnOrder = new clsOrder();
        String Error = "";
        String Customer_Id = "";
        Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
        Assert.AreNotEqual(Error,"");
        }
        public void Customer_IdMin()
        {
        clsOrder AnOrder = new clsOrder();
        String Error = "";
        String Customer_Id = "a";
        Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
        Assert.AreEqual(Error, "");
        }

          [TestMethod]
          public void Customer_IdMinPlusOne()
         {
           clsOrder AnOrder = new clsOrder();
            String Error = "";
           string Customer_Id = "aa";
           Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
           Assert.AreEqual(Error, "");
        }

         [TestMethod]
          public void Customer_IdMaxLessOne()
           {
              clsOrder AnOrder = new clsOrder();
              String Error = "";
              string Customer_Id = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
              Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
              Assert.AreEqual(Error, "");
        }
         [TestMethod]
        public void Customer_IdMax()
        {
          clsOrder AnOrder = new clsOrder();
          String Error = "";
          string Customer_Id = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
          Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
          Assert.AreEqual(Error, "");
             }

         [TestMethod]
         public void Customer_IdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Customer_Id = "aaa";
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreEqual(Error, "");
          }
             [TestMethod]
                public void Customer_IdMaxPlusOne()
              {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
              string Customer_Id = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
               Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
                 Assert.AreNotEqual(Error, "");
               }

             [TestMethod]
               public void Customer_IdExtremeMax()
               {
                   clsOrder AnOrder = new clsOrder();
                  String Error = "";
                  string Customer_Id = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                  Customer_Id = Customer_Id.PadRight(500, 'a');
                 Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost, DateOfOrder);
                  Assert.AreNotEqual(Error, "");
             }
        [TestMethod]
        public void Staff_IdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String Staff_Id = "";
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Staff_IdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String Staff_Id = "1";
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_IdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "11";
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreEqual(Error, "");
        }

         [TestMethod]
        public void Staff_IdMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "1111111111111111111111111111111111111111111111111";
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Staff_IdMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "11111111111111111111111111111111111111111111111111";
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreEqual(Error, "");
        }

                [TestMethod]
        public void Staff_IdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "aaa";
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Staff_IdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "111111111111111111111111111111111111111111111111111";
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_IdExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "11111111111111111111111111111111111111111111111111";
            Staff_Id = Staff_Id.PadRight(100, '1');
            Error = AnOrder.Valid( Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
    }
}




