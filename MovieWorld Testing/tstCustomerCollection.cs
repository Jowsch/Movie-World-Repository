using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWorldClasses;
using System.Collections.Generic;

namespace MovieWorld_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clsCustomers> TestList = new List<clsCustomers>();

            clsCustomers TestItem = new clsCustomers();

            TestItem.active = true;
            TestItem.customer_id = 1;
            TestItem.first_name = "Bilbo";
            TestItem.last_name = "Baggins";
            TestItem.email = "bilboboy@hotmail.com";
            TestItem.create_date = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomers TestCustomer = new clsCustomers();

            TestCustomer.active = true;
            TestCustomer.customer_id = 1;
            TestCustomer.first_name = "Bilbo";
            TestCustomer.last_name = "Baggins";
            TestCustomer.email = "bilboboy@hotmail.com";
            TestCustomer.create_date = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestCustomer;

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clsCustomers> TestList = new List<clsCustomers>();

            clsCustomers TestItem = new clsCustomers();

            TestItem.active = true;
            TestItem.customer_id = 1;
            TestItem.first_name = "Bilbo";
            TestItem.last_name = "Baggins";
            TestItem.email = "bilboboy@hotmail.com";
            TestItem.create_date = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomers TestItem = new clsCustomers();

            Int32 PrimaryKey = 0;

            TestItem.active = true;
            TestItem.customer_id = 1;
            TestItem.first_name = "Bilbo";
            TestItem.last_name = "Baggins";
            TestItem.email = "bilboboy@hotmail.com";
            TestItem.create_date = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();

            TestItem.customer_id = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

    }
}
