using System.Collections.Generic;
using System;
using System.Linq;

namespace Spa2.Models
{
    public class Repository : IRepository

    {
        //LISTS
        public List<Customer> Customers { get; } = new List<Customer>();
        
        public List<ServiceProvider> ServiceProviders { get;  } = new List<ServiceProvider>();
 
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();




        //EXCEPTIONS
        public class InvalidCustomerException : Exception
        {
            public InvalidCustomerException(string message) : base(message)
            {
            }
        }

        public class InvalidAppointmentException : Exception
        {
            public InvalidAppointmentException(string message) : base(message)
            {
            }
        }
        public class InvalidServiceProviderException : Exception
        {
            public InvalidServiceProviderException(string message) : base(message)
            {
            }
        }

        //ADD AND REMOVE CUSTOMERS
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
        public void RemoveCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }


        //ADD AND REMOVE SERVICE PROVIDERS
        public void AddServiceProvider(ServiceProvider serviceProvider)
        {
            ServiceProviders.Add(serviceProvider);
        }
        public void RemoveServiceProvider(ServiceProvider serviceProvider)
        {
            ServiceProviders.Remove(serviceProvider);
        }

        //ADD AND REMOVE APPOINTMENTS
        public void AddAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
            Appointments = Appointments.OrderBy(a => a.Day).ThenBy(a => a.Hour).ToList();
            
        }

        public void RemoveAppointment(Appointment appointment)
        {
            Appointments.Remove(appointment);
            
            
        }

        public void BookAppointment(Appointment appointment)
        {
            List<Appointment> appointments = this.Appointments;

           

            var isInvalidAppointment = appointments.Any(a => ((a.Name == appointment.Name
                || a.Provider == appointment.Provider)
                && a.Day == appointment.Day && a.Hour == a.Hour));
            if (isInvalidAppointment)
                throw new InvalidAppointmentException("Invalid Appointment");

            var isValidCustomer = Customers.Any(c => c.FirstName == appointment.Name);
            if (!isValidCustomer)
            {
                throw new InvalidCustomerException("Invalid Customer");
            }

            var isValidServiceProvider = ServiceProviders.Any(c => c.FullName == appointment.Provider);
            if (!isValidServiceProvider)
            {
                throw new InvalidServiceProviderException("Invalid Service Provider");
            }
           
            this.AddAppointment(appointment);
        }



    }
}

                
        
