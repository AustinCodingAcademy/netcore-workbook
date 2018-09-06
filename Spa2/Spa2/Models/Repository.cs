using System.Collections.Generic;
using System;
using System.Linq;
using Spa2.Data;
using Microsoft.EntityFrameworkCore;

namespace Spa2.Models
{
    public class Repository : IRepository

    {
        //EXCEPTIONS
        public class InvalidAppointmentException : Exception
        {
            public InvalidAppointmentException(string message) : base(message)
            {
            }
        }

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

                
        
