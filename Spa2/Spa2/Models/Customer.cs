using System;


namespace Spa2.Models
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
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
