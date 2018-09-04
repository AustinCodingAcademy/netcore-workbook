using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spa2.Data;

namespace Spa2.Models
{
    public interface IRepository
    {
        //List<Customer> Customers { get; }
        //List<ServiceProvider> ServiceProviders { get; }
        //List<Appointment> Appointments { get; set; }

 
        //void AddCustomer(Customer customer);
        //void RemoveCustomer(Customer customer);
        //void AddServiceProvider(ServiceProvider serviceProvider);
        //void RemoveServiceProvider(ServiceProvider serviceProvider);
        //void AddAppointment(Appointment appointment);
        void BookAppointment(Appointment appointment, ApplicationContext context);
        //void RemoveAppointment(Appointment appointment);
        
    }
}
