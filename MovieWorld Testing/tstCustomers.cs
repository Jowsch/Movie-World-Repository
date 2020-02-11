using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieWorld_Testing
{
    [TestClass]
    public class tstCustomers
    {
        [TestMethod]
        public void CustomerNoExists()
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

    }
}
