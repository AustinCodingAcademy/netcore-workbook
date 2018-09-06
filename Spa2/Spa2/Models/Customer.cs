using System;
using System.Collections.Generic;

namespace Spa2.Models
{
    public class Customer
    {
        public Customer()
        {
            CustomerId = Guid.NewGuid();
        }

        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
