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


    //[TestClass]
    //public class UnitTest2
    //{


        //[TestMethod]
        //public void TestAddCusomterWorksProperly()
        //{
        //    mockrepository repository = new mockrepository();
            
        //    var customercontroller = new CustomerController(repository);
        //    var actionresult = customercontroller.Index();
        //    Assert.IsNotNull(actionresult);
        //    Assert.IsTrue(repository.customerswasCalled);

        //}

    //    public class mockrepository : IRepository
    //    {
    //        public bool customerswasCalled { get; set; }
    //        public List<Customer> Customers
    //        {
    //            get
    //            {
    //                customerswasCalled = true;
    //                return new List<Customer>();
    //            }

    //        }

    //        public List<ServiceProvider> ServiceProviders => throw new System.NotImplementedException();

    //        public List<Appointment> Appointments { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }


    //}


}
