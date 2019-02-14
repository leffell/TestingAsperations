using System;
////////////////////////////////////////////////////////////////////////////////
/// Change History
/// Developer   Date    Description
/// Laurie      2/3     Added a few services to the configure services method.
/// Laurie      2/3     Note to self, go back and add to the configure section, refer to pluralsight for help
/// 

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TestingAsperations.Models;

namespace TestingAsperations
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {   //  If an interface is needed for the course, student home, or teacher home page, this will create a new instance with the mock data everytime.
            services.AddTransient<ICourseRepo, MockCourseRepo>();
            services.AddTransient<IStudentHomeRepo, MockStudentHomeRepo>();
            services.AddTransient<ITeacherHomeRepo, MockTeacherHomeRepo>();
            //  This tells the application that the project will use MVC, since application was created empty.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // This is for middleware components. The sequence middleware is important for the workload.
        //***************************More needs to be added here, refer to plural sight
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Testing Asperations");
            });
        }
    }
}
