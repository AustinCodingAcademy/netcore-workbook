using System;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BaseProject.Intrastructure
{
    public class UnwrapExceptionMiddleware : Exception
    {
        private readonly RequestDelegate next;

        public UnwrapExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                //throw ex;
                ExceptionDispatchInfo.Capture(ex.GetBaseException()).Throw();
            }
            //var start = new Stopwatch();
            //await next();
            //start.Stop();
            //Console.WriteLine(start.ElapsedMilliseconds);

        }
    }
}
