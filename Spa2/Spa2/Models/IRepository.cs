using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spa2.Data;

namespace Spa2.Models
{
    public interface IRepository
    {
        void BookAppointment(Appointment appointment, ApplicationContext context);        
    }
}
