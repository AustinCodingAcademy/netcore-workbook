using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spa2.Models
{
    public class ServiceProvider
    {
        public ServiceProvider()
        {
            ServiceProviderId = Guid.NewGuid();
        }

        public Guid ServiceProviderId { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ServiceProviderName 
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
