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
    }
}
