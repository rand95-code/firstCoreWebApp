using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace firstCoreWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // h�r l�ger man linkar!
            services.AddMvc(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            //app.UseDefaultFiles(); //looks for index.html or default.html in wwwwroot folder. 
            app.UseStaticFiles(); //default opens up the wwwroot folder to be accessed.

            app.UseRouting();

       
            app.UseEndpoints(endpoints =>
            {
                // special routes befor default
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

                //endpoints.MapGet("/", async context =>
                //{
                   // await context.Response.WriteAsync("Hello World!");
                //});
            });
        }
    }
}
