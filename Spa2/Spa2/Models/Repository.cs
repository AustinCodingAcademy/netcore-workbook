using System.Collections.Generic;
using System;
using System.Linq;
using Spa2.Data;
using Microsoft.EntityFrameworkCore;

namespace Spa2.Models
{
    public class Repository : IRepository

    {
        //LISTS
        //public List<Customer> Customers { get; } = new List<Customer>();       
        //public List<ServiceProvider> ServiceProviders { get; } = new List<ServiceProvider>();
        //public List<Appointment> Appointments { get; set; } = new List<Appointment>();

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
        //public void AddCustomer(Customer customer)
        //{
        //    Customers.Add(customer);
        //}

        //public void RemoveCustomer(Customer customer)
        //{
        //    Customers.Remove(customer);
        //}

        ////ADD AND REMOVE SERVICE PROVIDERS
        //public void AddServiceProvider(ServiceProvider serviceProvider)
        //{
        //    ServiceProviders.Add(serviceProvider);
        //}

        //public void RemoveServiceProvider(ServiceProvider serviceProvider)
        //{
        //    ServiceProviders.Remove(serviceProvider);
        //}

        ////ADD AND REMOVE APPOINTMENTS
        //public void AddAppointment(Appointment appointment)
        //{
        //    Appointments.Add(appointment);                       
        //}

        //public void RemoveAppointment(Appointment appointment)
        //{
        //    Appointments.Remove(appointment);                       
        //}

        public void BookAppointment(Appointment appointment, ApplicationContext context)
        {
            List<Appointment> appointments = context.Appointments.Include(x => x.ServiceProvider).Include(x => x.Customer).ToList();

            var isInvalidAppointment = appointments.Any(a => (a.Customer == appointment.Customer
                || a.ServiceProvider == appointment.ServiceProvider)
                && a.Day == appointment.Day && a.Hour == appointment.Hour);
            if (isInvalidAppointment)
                throw new InvalidAppointmentException("Invalid Appointment");

            //var isvalidcustomer = context.customers.any(c => c.customername == appointment.name);
            //if (!isvalidcustomer)
            //{
            //    throw new invalidcustomerexception("invalid customer");
            //}

            //var isvalidserviceprovider = context.serviceproviders.any(c => c.serviceprovidername == appointment.provider);
            //if (!isvalidserviceprovider)
            //{
            //    throw new invalidserviceproviderexception("invalid service provider");
            //}

        }
    }



    
}

                
        
