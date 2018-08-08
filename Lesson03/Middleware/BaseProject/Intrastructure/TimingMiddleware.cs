using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BaseProject.Intrastructure
{
    public class TimingMiddleware
    {
        private readonly RequestDelegate next;

        public TimingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var start = new Stopwatch();
            start.Start();
            await next(context);
            start.Stop();
            Console.WriteLine(start.ElapsedMilliseconds);
        }
    }
}
