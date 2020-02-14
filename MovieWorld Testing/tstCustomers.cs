using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWorldClasses;

namespace MovieWorld_Testing
{
    [TestClass]
    public class tstCustomers
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            int TestData = 0;

            ACustomer.customer_id = TestData;
            Assert.AreEqual(ACustomer.customer_id, TestData);
        }

        [TestMethod]
        public void CreateDatePropertyOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            DateTime TestData = DateTime.Now.Date;

            ACustomer.create_date = TestData;
            Assert.AreEqual(ACustomer.create_date, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            string TestData = "Joe";

            ACustomer.first_name = TestData;
            Assert.AreEqual(ACustomer.first_name, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            string TestData = "Bloggs";

            ACustomer.last_name = TestData;
            Assert.AreEqual(ACustomer.last_name, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            string TestData = "Joescho@outlook.com";

            ACustomer.email = TestData;
            Assert.AreEqual(ACustomer.email, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean TestData = true;

            ACustomer.active = TestData;
            Assert.AreEqual(ACustomer.active, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;

            Int32 CustomerNum = 1;

            Found = ACustomer.Find(CustomerNum);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerNumFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNum = 21;
            Found = ACustomer.Find(CustomerNum);
            if(ACustomer.customer_id != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
