using EmployeeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Services.Interface
{
    public interface IEmpService : IEntityService<EmployeeMasters>
    {
        EmployeeMasters GetById(int Id);
        Boolean DeleteEmployee(int Id);
    }
}
