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
            TestItem.OrderNo = "1";
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
            TestOrder.OrderNo = "1";
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
            TestItem.OrderNo = "1";
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.Customer_Id = "ubay";
            TestItem.TotalCost = "5.50";
            TestItem.Staff_Id = "1";

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
            
        }
    }

