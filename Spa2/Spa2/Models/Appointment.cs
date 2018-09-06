using System.Collections.Generic;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Spa2.Models
{
    public partial class Appointment
    {

        public Appointment()
        {
            AppointmentId = Guid.NewGuid();
        }
     
        public Guid AppointmentId { get; set; }  
        public Days Day { get; set; }
        public Hours Hour { get; set; }
        public ServiceProvider ServiceProvider { get; set; }
        public Guid ServiceProviderId { get; set; }
        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }








    }
}

