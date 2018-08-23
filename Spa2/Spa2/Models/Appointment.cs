using System;

namespace Spa2.Models
{
    public class Appointment
    {

        public Appointment()
        {
            Id = Guid.NewGuid();

        }


        public Guid Id { get; set; }

    
        public enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,

        };
        public Days Day { get; set; }

        public enum Hours { Nine=9, Ten=10, Eleven=11, Noon=2, One=1, Two=2, Three=3, Four=4 };
        public Hours Hour { get; set; }
        public string Name { get; set; }
        public string Provider { get; set; }

        

    }

 


}

