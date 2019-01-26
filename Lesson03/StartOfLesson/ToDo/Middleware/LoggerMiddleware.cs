using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Middleware
{
    public class LoggerMiddleware : IMiddleware
    {
        private readonly ILogger<LoggerMiddleware> _logger;
        public LoggerMiddleware(ILogger<LoggerMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            string path = context.Request.Path;
            String[] pathParts = path.Split("/");
            string controller = "";
            string action = "";
            string id = "";
            
            if (pathParts.Length == 4)
            {
                controller = pathParts[1];
                action = pathParts[2]; 
                id = pathParts[3];
            }

            //should only happen when ToDoController has been called
            if (controller == "ToDo")
            {
                //change the message
                //show the controller name, action, and id if available
                _logger.LogError("controller = " + controller + ". action = " + action + ". id = " + id);
            }
            
            
            

            

            await next(context);
        }




    }
}       