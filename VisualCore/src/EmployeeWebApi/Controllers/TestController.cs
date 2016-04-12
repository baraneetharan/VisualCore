using Microsoft.AspNet.Mvc;
using System;

namespace EmployeeWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Test")]
    public class TestController : Controller
    {
       
      
      

        // GET: api/Test
        [HttpGet]
        public Object Test()
        {
            
            return "TEST";
        }
    }
}