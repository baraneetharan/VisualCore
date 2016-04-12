using EmployeeWebApi.Controllers;
using EmployeeWebApi.Models;
using EmployeeWebApi.Services.Interface;
using Moq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace EmployeeWebApiTest.ControllerTest
{
    public class EmployeeMasterTest
    {
        List<EmployeeMasters> list = new List<EmployeeMasters>();
        EmployeeMasters empMaster = new EmployeeMasters(0, "reka", "dev", "reka.v@gfsl.com", "12586", "CBE");
        JObject obj = new JObject();
        int id = 1;
        int EmpID = 1;
        
        Mock<IEmpService> mockObject = new Mock<IEmpService>();
        public EmployeeMasterTest()
        {
            list.Add(empMaster);
            obj.Add("emp_id", 1);
            
        }
        [Fact]
        public void GetEmployeesTest()
        {
            //Assign
           
            mockObject.Setup(x => x.GetAll()).Returns(list);
            var employeeMastersController = new EmployeeMastersController(mockObject.Object);
            // Act
            var actual = employeeMastersController.GetEmployees();
            Debug.WriteLine("Actual::" + actual);
            // Assert
            Assert.Equal(list, actual);
        }

        [Fact]
        public void createEmployeeMaster()
        {
            //Assign
            JObject resObj = new JObject();
            resObj.Add("result",true);
            mockObject.Setup(x => x.Create(empMaster)).Returns(true);
            var employeeMastersController = new EmployeeMastersController(mockObject.Object);
            // Act
            var actual = employeeMastersController.createEmployeeMaster(empMaster);
            Debug.WriteLine("Actual::" + actual);
            // Assert
            Assert.Equal(resObj, actual);
        }

        [Fact]
        public void GetEmployeeMasterTest()
        {
            //Assign
            JObject resObj = new JObject();
            resObj.Add("result",true);
            mockObject.Setup(x => x.GetById(id)).Returns(empMaster);
            var employeeMastersController = new EmployeeMastersController(mockObject.Object);
            // Act
            var actual = employeeMastersController.GetEmployeeMaster(obj);
            Debug.WriteLine("Actual::" + actual);
            // Assert
            Assert.Equal(empMaster, actual);
        }
        [Fact]
        public void DeleteEmployeeMasterTest()
        {
            //Assign
            JObject resObj = new JObject();
            resObj.Add("result",true);
            mockObject.Setup(x => x.DeleteEmployee(id)).Returns(true);
            var employeeMastersController = new EmployeeMastersController(mockObject.Object);
            //Act
            var actual = employeeMastersController.DeleteEmployeeMaster(EmpID);
            Debug.WriteLine("Actual::" + actual);
            // Assert
            Assert.Equal(resObj, actual);
        }
        [Fact]
        public void updateEmployeeMasterTest()
        {
            //Assign
            mockObject.Setup(x => x.Update(empMaster)).Returns(true);
            var employeeMastersController = new EmployeeMastersController(mockObject.Object);
            //Act
            var actual = employeeMastersController.updateEmployeeMaster(empMaster);
            Debug.WriteLine("Actual::" + actual);
            // Assert
            Assert.Equal(true, actual);
        }
    }
}
