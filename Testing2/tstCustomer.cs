using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            int testData = 1;
            ACustomer.CustomerId = testData;
            Assert.AreEqual(ACustomer.CustomerId, testData);
        }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string testData = "siewe";
            ACustomer.CustomerId = testData;
            Assert.AreEqual(ACustomer.CustomerName, testData);
        }
    }
}
