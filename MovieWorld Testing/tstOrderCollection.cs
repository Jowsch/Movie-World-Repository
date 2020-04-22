using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace MovieWorldTesting
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderlistOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.AvailableSeats = true;
            TestItem.OrderNo = 1;
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.Customer_Id = "ubay";
            TestItem.TotalCost = "5.50";
            TestItem.Staff_Id = "1";

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
            

        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            
            TestOrder.AvailableSeats = true;
            TestOrder.OrderNo = 1;
            TestOrder.DateOfOrder = DateTime.Now.Date;
            TestOrder.Customer_Id = "ubay";
            TestOrder.TotalCost = "5.50";
            TestOrder.Staff_Id = "1";

            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder); 
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.AvailableSeats = true;
            TestItem.OrderNo = 1;
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.Customer_Id = "ubay";
            TestItem.TotalCost = "5.50";
            TestItem.Staff_Id = "1";

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            TestItem.OrderNo = 1;
            TestItem.Customer_Id = "ubay";
            TestItem.TotalCost = "1";
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.Staff_Id = "1";
            TestItem.AvailableSeats = true;
        
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllCustomers = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.OrderNo = 1;
            TestItem.Customer_Id = "ubay";
            TestItem.TotalCost = "1";
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.Staff_Id = "1";
            TestItem.AvailableSeats = true;

            AllCustomers.ThisOrder = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.OrderNo = PrimaryKey;

            AllCustomers.ThisOrder.Find(PrimaryKey);
            AllCustomers.Delete();

            Boolean Found = AllCustomers.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.OrderNo = 1;
            TestItem.Customer_Id = "ubay";
            TestItem.TotalCost = "1";
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.Staff_Id = "1";
            TestItem.AvailableSeats = true;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderNo = PrimaryKey;

            TestItem.OrderNo = 3;
            TestItem.Customer_Id = "Ahmad";
            TestItem.TotalCost = "2";
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.Staff_Id = "2";
            TestItem.AvailableSeats = false;

            AllOrders.ThisOrder = TestItem;

            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }


    }
}

