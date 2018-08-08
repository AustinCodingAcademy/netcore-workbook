using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseProject.Intrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace BaseProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IDateTimeProvider>(new DateTimeProvider());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseResponseCaching();

            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}

//    public class RequestLoggingMiddleware
//        {
//            private readonly RequestDelegate _next;
//            private readonly ILogger<RequestLoggingMiddleware> _logger;

//            public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
//            {
//                _next = next;
//                _logger = logger;
//            }


//            public async Task Invoke(HttpContext context)
//            {
//                var startTime = DateTime.UtcNow;

//                var watch = Stopwatch.StartNew();
//                await _next.Invoke(context);
//                watch.Stop();

//                var logTemplate = @"
//    Client IP: {clientIP}
//    Request path: {requestPath}
//    Request content type: {requestContentType}
//    Request content length: {requestContentLength}
//    Start time: {startTime}
//    Duration: {duration}";

//                _logger.LogInformation(logTemplate,
//                    context.Connection.RemoteIpAddress.ToString(),
//                    context.Request.Path,
//                    context.Request.ContentType,
//                    context.Request.ContentLength,
//                    startTime,
//                    watch.ElapsedMilliseconds);
//            Console.Write(_logger);
//            }
//        }
//}
