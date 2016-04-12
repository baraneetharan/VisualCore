using Microsoft.AspNet.Mvc;
using System;

namespace EmployeeWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Sample")]
    public class SampleController : Controller
    {
       
      
      

        // GET: api/Sample
        [HttpGet]
        public Object Sample()
        {
            
            return "SAMPLE";
        }
    }
}