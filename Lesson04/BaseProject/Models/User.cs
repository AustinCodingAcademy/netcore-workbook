using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace BaseProject.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class User
    {
        [Key]

        public int Id { get; set; }
        public string FirstName{ get; set; }

        public string LastName { get; set; }


 
    //    private readonly RequestDelegate _next;

    //    public User(RequestDelegate next)
    //    {
    //        _next = next;
    //    }

    //    public Task Invoke(HttpContext httpContext)
    //    {

    //        return _next(httpContext);
    //    }
    //}

    //// Extension method used to add the middleware to the HTTP request pipeline.
    //public static class UserExtensions
    //{
    //    public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<User>();
    //    }
    }
}
