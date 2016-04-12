using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using EmployeeWebApi.Models;
using System;
using EmployeeWebApi.Services.Interface;
using Newtonsoft.Json.Linq;

namespace EmployeeWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/EmployeeMasters")]
    public class EmployeeMastersController : Controller
    {
       
        [FromServices]
        private IEmpService _employeeService { get; set; }


        public EmployeeMastersController(IEmpService employeeService)
        {
            // _context = context;
            _employeeService = employeeService;
        }

        // GET: api/EmployeeMasters
        [HttpGet]
        public Object GetEmployees()
        {
            var obj = _employeeService.GetAll();
            return obj;
        }

        //POST: api/EmployeeMasters/createEmployeeMaster
        //[Route("createEmployeeMaster")]
        [HttpPost]
        public Object createEmployeeMaster([FromBody] EmployeeMasters employeeMaster)
        {
            
            Console.WriteLine("DATA:::"+employeeMaster.ToString());
            Console.WriteLine("DATA:::"+employeeMaster.EmpID.ToString());
            JObject resObj = new JObject();
            
            Boolean res = false;
            if(((employeeMaster.EmpID) > 0 || (employeeMaster.EmpID) !=0 )) 
            {
                res = _employeeService.Update(employeeMaster);
                resObj.Add("result",res);
                
            }else{
                res = _employeeService.Create(employeeMaster);
                resObj.Add("result",res);
            }
            
            return resObj;
        }

       // POST: api/EmployeeMasters/GetEmployeeMaster
       [Route("GetEmployeeMaster")]
        [HttpPost]
        public Object GetEmployeeMaster([FromBody] JObject id)
        {
           dynamic did = JObject.Parse(id.ToString());
           int empId = int.Parse(did.emp_id.ToString());
            Object employeeMaster = _employeeService.GetById(empId);

            if (employeeMaster == null)
            {
                return HttpNotFound();
            }

            return employeeMaster;
        }

        // POST: api/EmployeeMasters/DeleteEmployeeMaster
       // [Route("DeleteEmployeeMaster")]
        [HttpDelete]
        public object DeleteEmployeeMaster([FromQuery]  int EmpID)
        {
            JObject resObj = new JObject();
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }
           // dynamic Empid = JObject.Parse(emp_id.ToString());
            //int empId = Int32.Parse(Empid.EmpID.ToString());
            Boolean res = _employeeService.DeleteEmployee(EmpID);
            resObj.Add("result",res);
            //if (!result)
            //{
            //    return HttpNotFound();
            //}
            return resObj;
        }

        // POST: api/EmployeeMasters/updateEmployeeMaster
        [Route("updateEmployeeMaster")]
        [HttpPost]
        public Object updateEmployeeMaster([FromBody] EmployeeMasters employeeMaster)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }
            Boolean res = _employeeService.Update(employeeMaster);
            return res;
        }




        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        _context.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool EmployeeMasterExists(int id)
        //{
        //    return _context.Employees.Count(e => e.EmpID == id) > 0;
        //}
    }
}