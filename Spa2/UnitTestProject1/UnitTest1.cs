using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spa2.Models;
using Spa2.Controllers;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCustomerNameShouldFormatProperly()
        {
            var customer = new Customer();
            customer.FirstName = "Dylan";
            customer.LastName = "Zocchi";
            var fullname = customer.CustomerName;
            Assert.AreEqual("Dylan Zocchi", fullname);  
        }
    }
}
