using System;
using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;
using Autofac;
using EmployeeWebApiTest.Autofac;
using Microsoft.AspNet.Hosting;
using Autofac.Extensions.DependencyInjection;

namespace EmployeeWebApiTest
{
    public class Startup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            var builder = new ContainerBuilder();

          
            builder.RegisterModule(new AutofacModule());
            builder.Populate(services);

            var container = builder.Build();
            // DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            return container.Resolve<IServiceProvider>();
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
           
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}

