using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieWorldClasses;

namespace MovieWorld_Testing
{
    [TestClass]
    public class tstStaff
    {
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
    }
}