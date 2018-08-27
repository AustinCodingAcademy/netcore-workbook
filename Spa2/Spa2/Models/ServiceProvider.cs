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
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set;}
        public string FullName { get; set; }
    }
}
