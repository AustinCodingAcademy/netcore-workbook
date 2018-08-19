using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SPA.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public string Date;

        public List<ServiceProvider> serviceProviders;

        public Appointment(string Date)
        {
            this.Date = Date;
            this.serviceProviders = new List<ServiceProvider>();
        }

    }


    public class Customer
    {
        public int Id { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
    }





        //public List<Appointment> appointments;


        //public Customer(string first_name, string last_name)
        //{
        //    this.first_name = first_name;
        //    this.last_name = last_name;
        //}

        //public string AddContainer(Container container)
        //{
        //if (this.containers.Count < this.size)
        //{
        //    this.containers.Add(container);
        //    return "Container Added";

        //}
        //return "NO MORE ROOM";





    public class ServiceProvider
    {
        public int Id { get; set; }
        public string name;



        //constructor funtion
        public ServiceProvider(int Id, string name)
        {
            this.name = name;
        }


    }
}
