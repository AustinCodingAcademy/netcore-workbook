using System.Collections.Generic;
using System.Linq;

namespace Spa2.Models
{
    public class Repository
    {
        //private int _availableTimes = { 8, 9, 10, 11, 12, 1, 2, 3, 4, 5 };
        private List<ServiceProvider> serviceProviders = new List<ServiceProvider>();
        public List<Appointment> appointments = new List<Appointment>();

        public List<Customer> Customers { get; } = new List<Customer>();

        public List<ServiceProvider> ServiceProviders
        {
            get
            {
                return serviceProviders;
            }
        }

        public List<Appointment> Appointments
        {
            get
            {
                return appointments;
            }
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void AddServiceProvider(ServiceProvider serviceProvider)
        {
            serviceProviders.Add(serviceProvider);
        }

        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }
    }
}

        //public void BookAppointment(Appointment appointment)
        //{
        //    List<Appointment> appointments = this.appointments;
        //    bool cflag = false;
        //    bool sflag = false;
        //    bool isEmpty = !this.appointments.Any();
        //    if (!isEmpty)
        //    {
                //var isInvalidAppointment = appointments.Any(a => ((appointment.CustomerFullName == a.CustomerFullName
                // || appointment.ServiceProviderFullName == a.ServiceProviderFullName)
                // && appointment.Time == a.Time)
                // || !_availableTimes.Contains(appointment.Time))
                // );
                //if (isInvalidAppointment)
                // return; // throw expection?

                //    foreach (Appointment a in appointments)
                //    {

                //        if (((appointment.name == a.name
                //        || appointment.ServiceProvidername == a.ServiceProvidername)
                //        && appointment.Date == a.Date)
                //        || !_availableTimes.Contains(appointment.Date))
                //        {
                //            return;
                //        }
                //    }
                //}
                //else if (!_availableTimes.Contains(appointment.Date))
                //{
                //    return;
                //}
                ////// isValidCustomer?
                ////if (isInvalidCustomer(appointment.CustomerFullName))
                ////{
                //// // throw invalidcustomerexception
                ////}
                //foreach (Customer c in this.Customers)
                //{
                //    if (appointment.CustomerFullName == c.FullName)
                //    {
                //        cflag = true;
                //        break;
                //    }
                //}
                //if (!cflag)
                //    return;
                //foreach (ServiceProvider s in this.ServiceProviders)
                //{
                //    if (appointment.ServiceProviderFullName == s.FullName)
                //    {
                //        sflag = true;
                //        break;
                //    }
                //}
                //if (!sflag)
                //    return;
                //this.AddAppointment(appointment);
                //}

                //private bool IsInvalidCustomer(string fullName)
                //{
                // return !this.Customers.Any(c => c.FirstName == fullName);
                //}
            
        
