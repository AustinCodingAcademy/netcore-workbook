using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ToDoApp.Models
{
    public class ToDoUser : IdentityUser<int>
    {
        public DateTime? DateOfBirth { get; set; }
        
    }
}
