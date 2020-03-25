using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWorldClasses;

namespace MovieWorldTesting
{
    [TestClass]
    public class tstCustomers
    {
        string firstName = "Joe";
        string lastName = "Schofield";
        string email = "Joescho@outlook.com";
        string createDate = "13/01/1999";

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
            Int32 CustomerNum = 1;
            Found = ACustomer.Find(CustomerNum);
            if(ACustomer.customer_id != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNum = 1;
            Found = ACustomer.Find(CustomerNum);
            if (ACustomer.first_name != "Joe")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNum = 1;
            Found = ACustomer.Find(CustomerNum);
            if (ACustomer.last_name != "Schofield")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNum = 1;
            Found = ACustomer.Find(CustomerNum);
            if (ACustomer.email != "joescho@outlook.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNum = 1;
            Found = ACustomer.Find(CustomerNum);
            if (ACustomer.active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCreateDateFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNum = 1;
            Found = ACustomer.Find(CustomerNum);
            if (ACustomer.create_date != Convert.ToDateTime("30-01-2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            Error = ACustomer.Valid(firstName, lastName, email, createDate);
        }

        [TestMethod]
        public void firstNameMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string firstName = "";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void firstNameMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string firstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        public void firstNameMax()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string firstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void firstNameMid()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string firstName = "aaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void firstNameMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string firstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void firstNameExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string firstName = "";

            firstName = firstName.PadRight(500, 'a');

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string createDate = TestDate.ToString();

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string createDate = TestDate.ToString();

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string createDate = TestDate.ToString();

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string createDate = TestDate.ToString();

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string createDate = TestDate.ToString();

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";
            string createDate = "this is not a date!";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string lastName = "";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string lastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        public void lastNameMax()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string lastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMid()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string lastName = "aaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string lastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastNameExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string lastName = "";

            lastName = lastName.PadRight(500, 'a');

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void emailMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string email = "";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void emailMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        public void emailMax()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void emailMid()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string email = "aaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void emailMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void emailExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();

            String Error = "";

            string email = "";

            email = email.PadRight(500, 'a');

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void emailCorrectFormat()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string email = "";
            email = "Testing@hotmail.co.uk";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void emailIncorrectFormat()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string email = "";
            email = "Testing wrong email";

            Error = ACustomer.Valid(firstName, lastName, email, createDate);

            Assert.AreNotEqual(Error, "");

        }
    }
}
