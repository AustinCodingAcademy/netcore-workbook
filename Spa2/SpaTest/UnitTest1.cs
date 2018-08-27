using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spa2;

namespace SpaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomerTest()
        {
            Customer ct = new Customer();
            string res = ct.Add(FirstName, LastName);
            Assert.AreEqual(rs, CustomerName);           
        }
    }
}
