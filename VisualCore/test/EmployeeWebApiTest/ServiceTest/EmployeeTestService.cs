using EmployeeWebApi.Models;
using EmployeeWebApi.Repositories.Interface;
using EmployeeWebApi.Services.Interface;
using EmployeeWebApi.Services.Services;
using Moq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Xunit;

namespace EmployeeWebApiTest.ServiceTest
{
    public class EmployeeTestService
    {
        private Mock<IEmpRepository> _mockRepository;
        private IEmpService _service;
        Mock<IUnitOfWorks> _mockUnitWork;
        List<EmployeeMasters> list;
        EmployeeMasters empMaster;
        JObject obj = new JObject();
        int id = 1;
        public EmployeeTestService()
        {
            _mockRepository = new Mock<IEmpRepository>();
            _mockUnitWork = new Mock<IUnitOfWorks>();
            _service = new EmpService(_mockUnitWork.Object, _mockRepository.Object);

            empMaster = new EmployeeMasters(1, "reka", "dev", "reka.v@gfsl.com", "12586", "CBE");
            list = new List<EmployeeMasters>() { empMaster };
            obj.Add("emp_id", 1);
        }
        [Fact]
        public void GetByIdTest()
        {
            _mockRepository.Setup(x => x.GetById(id)).Returns(empMaster);
            var actual = _service.GetById(id);
            Assert.NotNull(actual);
            Assert.Equal(empMaster, actual);
        }
        [Fact]
        public void DeleteEmployeeTest()
        {
            _mockRepository.Setup(x => x.Delete(id)).Returns(true);
            var actual = _service.DeleteEmployee(id);
            Assert.NotNull(actual);
            Assert.Equal(true, actual);
        }
        [Fact]
        public void UpdateTest()
        {
            _mockRepository.Setup(x => x.Update(empMaster)).Returns(true);
            var actual = _service.Update(empMaster);
            Assert.NotNull(actual);
            Assert.Equal(true, actual);
        }
        [Fact]
        public void CreateTest()
        {
            _mockRepository.Setup(x => x.Insert(empMaster)).Returns(true);
            var actual = _service.Create(empMaster);
            Assert.NotNull(actual);
            Assert.Equal(true, actual);
        }
        [Fact]
        public void GetAllTest()
        {
            _mockRepository.Setup(x => x.SelectAll()).Returns(list);
            var actual = _service.GetAll();
            Assert.NotNull(actual);
            Assert.Equal(list, actual);
        }
    }
}
