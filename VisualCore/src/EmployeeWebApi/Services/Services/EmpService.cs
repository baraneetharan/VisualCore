using EmployeeWebApi.Models;
using EmployeeWebApi.Repositories.Interface;
using EmployeeWebApi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Services.Services
{
    public class EmpService : EntityService<EmployeeMasters>, IEmpService
    {
        IUnitOfWorks _unitOfWork;
        IEmpRepository _empRepository;

        public EmpService(IUnitOfWorks unitOfWork, IEmpRepository empRepository)
          : base(unitOfWork, empRepository)
      {
            _unitOfWork = unitOfWork;
            _empRepository = empRepository;
        }

        public EmployeeMasters GetById(int Id)
        {
            return _empRepository.GetById(Id);
        }

        public Boolean DeleteEmployee(int Id)
        {
            return  _empRepository.Delete(Id);
        }
    }
}
