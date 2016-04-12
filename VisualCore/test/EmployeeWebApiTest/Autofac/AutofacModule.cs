using Autofac;
using EmployeeWebApi.Controllers;
using EmployeeWebApi.Models;
using EmployeeWebApi.Repositories.Interface;
using EmployeeWebApi.Repositories.Repository;
using EmployeeWebApi.Services.Interface;
using EmployeeWebApi.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApiTest.Autofac
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmployeeMastersController>()
                .As<EmployeeMastersController>()
                .InstancePerDependency();

            builder.RegisterType<EmpService>()
                .As<IEmpService>()
                .InstancePerDependency();

            builder.RegisterType<EmpRepository>()
                .As<IEmpRepository>()
                .InstancePerDependency();

            builder.RegisterType<UnitOfWorks>()
                .As<IUnitOfWorks>()
                .InstancePerDependency();

            builder.RegisterType<EmployeeDbContext>()
                           .As<EmployeeDbContext>()
                           .InstancePerDependency();


        }
    }
}
