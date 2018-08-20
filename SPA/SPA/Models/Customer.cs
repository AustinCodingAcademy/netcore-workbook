using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SPA.Models
{

    public class Customer
    {

        public int Id { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }

        //public void EnterName(string name)
        //{
        //    this._lastName = name.ToString<_firstName>;
        //}


        //    public Customer(string _firstName, string _lastName)
        //    {
        //        //this._firstName = _firstName;
        //        this._lastName = _lastName;
        //    }

        //    public List<Customer> Names { get; set; }

        //    public static implicit operator List<object>(Customer v)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}






    }
}
