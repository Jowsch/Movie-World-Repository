using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWorldClasses;

namespace MovieWorld_Testing
{
    [TestClass]
    public class TstOrder
    {
        string OrderNo = "1";
        string DateOfOrder = "24/03/2020";
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
            string TestData = "1";
            AnOrder.OrderNo = TestData;
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "1";
            AnOrder.OrderNo = TestData;
            Assert.AreEqual(AnOrder.OrderNo, TestData);
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
            string TestData = "1";
            AnOrder.Staff_Id = TestData;
            Assert.AreEqual(AnOrder.Staff_Id, TestData);
        }

        public void TestTotalCostFound()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "5.50";
            AnOrder.TotalCost = TestData;
            Assert.AreEqual(AnOrder.TotalCost, TestData);
        }

        [TestMethod]
        public void AvailableSeatsFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool TestData = true;
            AnOrder.AvailableSeats = TestData;
            Assert.AreEqual(AnOrder.AvailableSeats, TestData);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderNo = "1";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "12";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "1111111111111111111111111111111111111111111111111";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "11111111111111111111111111111111111111111111111111";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "1111111111111111111111111";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "1111111111111111111111111111111111111111111111111111";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "1111111111111111111111111111111111111111111111111111";
            OrderNo = OrderNo.PadRight(500, '1');
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreNotEqual(Error, "");
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
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
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
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
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
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
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
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
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
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfOrderInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DateOfOrder = "This is not a date";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Customer_IdMinLessOne()
        {
        clsOrder AnOrder = new clsOrder();
        String Error = "";
        String Customer_Id = "";
        Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
        Assert.AreNotEqual(Error,"");
        }
        public void Customer_IdMin()
        {
        clsOrder AnOrder = new clsOrder();
        String Error = "";
        String Customer_Id = "a";
        Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
        Assert.AreEqual(Error, "");
        }

          [TestMethod]
          public void Customer_IdMinPlusOne()
         {
           clsOrder AnOrder = new clsOrder();
            String Error = "";
           string Customer_Id = "aa";
           Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
           Assert.AreEqual(Error, "");
        }

         [TestMethod]
          public void Customer_IdMaxLessOne()
           {
              clsOrder AnOrder = new clsOrder();
              String Error = "";
              string Customer_Id = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
              Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
              Assert.AreEqual(Error, "");
        }
         [TestMethod]
        public void Customer_IdMax()
        {
          clsOrder AnOrder = new clsOrder();
          String Error = "";
          string Customer_Id = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
          Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
          Assert.AreEqual(Error, "");
             }

         [TestMethod]
         public void Customer_IdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Customer_Id = "aaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
            Assert.AreEqual(Error, "");
          }
             [TestMethod]
                public void Customer_IdMaxPlusOne()
              {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
              string Customer_Id = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
               Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
                 Assert.AreNotEqual(Error, "");
               }

             [TestMethod]
               public void Customer_IdExtremeMax()
               {
                   clsOrder AnOrder = new clsOrder();
                  String Error = "";
                  string Customer_Id = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                  Customer_Id = Customer_Id.PadRight(500, 'a');
                 Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost, DateOfOrder);
                  Assert.AreNotEqual(Error, "");
             }
        [TestMethod]
        public void Staff_IdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String Staff_Id = "";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Staff_IdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String Staff_Id = "1";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_IdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "11";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreEqual(Error, "");
        }

         [TestMethod]
        public void Staff_IdMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "1111111111111111111111111111111111111111111111111";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Staff_IdMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "11111111111111111111111111111111111111111111111111";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreEqual(Error, "");
        }

                [TestMethod]
        public void Staff_IdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderNo = "aaa";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Staff_IdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "111111111111111111111111111111111111111111111111111";
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_IdExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Staff_Id = "11111111111111111111111111111111111111111111111111";
            Staff_Id = Staff_Id.PadRight(100, '1');
            Error = AnOrder.Valid(OrderNo, Customer_Id, Staff_Id, TotalCost,  DateOfOrder);
            Assert.AreNotEqual(Error, "");
        }



    }
}




