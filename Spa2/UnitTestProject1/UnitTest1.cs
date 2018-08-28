using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spa2.Models;
using Spa2.Controllers;

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


    [TestClass]
    public class UnitTest2
    {
        

        [TestMethod]
        public void TestAddCusomterWorksProperly()
        {
            IRepository repository = new Repository();
            var customercontroller = new CustomerController(repository);
            var actionresult = customercontroller.Index();
            Assert.IsNotNull(actionresult); 
          
        }

        public class MockedRepository 
    }
}
