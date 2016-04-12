using EmployeeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Repositories.Interface
{
    public interface IEmpRepository : IGenericRepository<EmployeeMasters>
    {
        EmployeeMasters GetById(int id);
        Boolean Delete(int id);
    }
}
