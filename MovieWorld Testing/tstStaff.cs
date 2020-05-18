using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWorldClasses;

namespace MovieWorld_Testing
{
    [TestClass]
    public class tstStaff
    {
        string StaffName = "Hussein Ahmed";
        string StaffPhoneNo = "7475166277";
        string StaffSalary = "2000";
        string StaffDOB = "01/07/1995";

        private int StaffID;

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffActiveOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the staff
            Boolean TestData = true;
            //assign the data to the staff
            AStaff.StaffActive = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AStaff.StaffActive, TestData);
        }

        [TestMethod]
        public void StaffDOBOK()
        {
            //create an instance of the class we want to create
            clsStaff Astaff = new clsStaff();
            //create some test data to assign the staff
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the staff
            Astaff.StaffDOB = TestData;
        }

        [TestMethod]
        public void StaffIDOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign the staff
            Int32 TestData = 1;
            //assign the data to the staff
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);

        }

        [TestMethod]
        public void StaffPhoneNoOK()
        {
            //create an instance of the class we want to create
            clsStaff Astaff = new clsStaff();
            //create some test data to assign the staff
            Int32 TestData = 1;
            //assign the data to the staff
            Astaff.StaffPhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Astaff.StaffPhoneNo, TestData);
        }

        [TestMethod]
        public void StaffNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign the staff
            String TestData = "Hussein";
            //assign the data to the staff
            AStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffSalaryOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign the staff
            Decimal TestData = 1;
            //assign the data to the staff
            AStaff.StaffSalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffSalary, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 21;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDOBFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffDOB != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.StaffName != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.StaffSalary != "Test Salary")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.StaffPhoneNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

      

        [TestMethod]
        public void StaffActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.StaffActive != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffSalary, StaffDOB);
            Assert.AreEqual(Error, "");
        }

        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "a"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffSalary, StaffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffSalary, StaffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffSalary, StaffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AStaff = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffSalary, StaffDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffSalary, StaffDOB}
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
