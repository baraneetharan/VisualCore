using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using EmployeeWebApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace EmployeeWebApiIntegrationTest.Test
{
     public class EmployeeMatserControllerIntegrationTest : BaseTestController

    {
        // private readonly TestServer _server;

        // public EmployeeMatserControllerIntegrationTest()
        // {
        //     _server = new TestServer(TestServer.CreateBuilder().UseStartup<Startup>());
        // }
        
      // [Fact]
        public void unitTest(){
          CreateUser();
         get_all_employees();
          UpdateUser();
          GetById();
          DeleteUser();
        }
        
//          [Fact]
        public async void CreateUser()
        {
            EmployeeMasters Details = new EmployeeMasters
            {
                EmpID = 0,
                EmpName = "Reka.v",
                Designation = "Developer",
                Email = "reka.v@kgfsl.com",
                Phone = "909909009",
               Address = "cbe"
            };
            JObject resObj = new JObject();
            
            using (var client = _server.CreateClient().AcceptJson())
            {
                resObj.Add("result",true);
                var Postresponse = client.PostAsync("api/EmployeeMasters/", 
                             new StringContent(JsonConvert.SerializeObject(Details).ToString(), 
                             Encoding.UTF8, "application/json"))
                            .Result;
                //var Create = await Postresponse.Content.ReadAsJsonAsync<EmployeeMasters>();
                var Create = await Postresponse.Content.ReadAsStringAsync();
                Debug.WriteLine("OUTPUT::::::"+Create);
                Console.WriteLine("OUTPUT::::::"+Create);
                
                
                //Assert.Equal(true);
                Assert.Equal(resObj,JObject.Parse(Create));
               // Assert.Empty(result);
            }
          }
      
       
//        [Fact]
        public async void get_all_employees()
        {
            using (var client = _server.CreateClient().AcceptJson())
            {
                var response = await client.GetAsync("api/EmployeeMasters");
                var result = await response.Content.ReadAsJsonAsync<List<EmployeeMasters>>();
 
                Assert.NotNull(result);
               // Assert.Empty(result);
            }
          }
        
//            [Fact]
          public async void UpdateUser(){
              //updateEmployeeMaster
              EmployeeMasters Details = new EmployeeMasters
            {
                EmpID=3,
                EmpName = "aaaa.v",
                Designation = "Developer",
                Email = "reka.v@kgfsl.com",
                Phone = "909909009",
               Address = "cbe"
            };
             JObject resObj = new JObject();
            resObj.Add("result",true);
            using (var client = _server.CreateClient().AcceptJson())
            {
                var Postresponse = client.PostAsync("api/EmployeeMasters/", 
                             new StringContent(JsonConvert.SerializeObject(Details).ToString(), 
                             Encoding.UTF8, "application/json"))
                            .Result;
                //var Create = await Postresponse.Content.ReadAsJsonAsync<EmployeeMasters>();
                var Update = await Postresponse.Content.ReadAsStringAsync();
                Debug.WriteLine("OUTPUT::::::"+Update);
                Console.WriteLine("OUTPUT::::::"+Update);
                
                
                //Assert.Equal(true);
                Assert.Equal(resObj,JObject.Parse(Update));
               // Assert.Empty(result);
          }
          }
           
//            [Fact]
          public async void GetById(){
              //GetEmployeeMaster
                JObject obj = new JObject();
              obj.Add("emp_id",3);
              
               using (var client = _server.CreateClient().AcceptJson())
                {
                var Postresponse = client.PostAsync("api/EmployeeMasters/GetEmployeeMaster", 
                             new StringContent(JsonConvert.SerializeObject(obj).ToString(), 
                             Encoding.UTF8, "application/json"))
                            .Result;
                //var Create = await Postresponse.Content.ReadAsJsonAsync<EmployeeMasters>();
                var res = await Postresponse.Content.ReadAsStringAsync();
                Debug.WriteLine("OUTPUT::::::"+res);
                Console.WriteLine("OUTPUT::::::"+res);
                
                
                //Assert.Equal(true);
                
                Assert.NotNull(res);
          }
          }
          [Fact]
          public async void DeleteUser(){
              JObject obj = new JObject();
              obj.Add("emp_id",2);
              JObject resObj = new JObject();
              resObj.Add("result",true);
              
               using (var client = _server.CreateClient().AcceptJson())
                {
                var Postresponse = client.DeleteAsync("api/EmployeeMasters?EmpID=3").Result; 
                            //  new StringContent(JsonConvert.SerializeObject(obj).ToString(), 
                            //  Encoding.UTF8, "application/json"))
                            // .Result;
                //var Create = await Postresponse.Content.ReadAsJsonAsync<EmployeeMasters>();
                var Delete = await Postresponse.Content.ReadAsStringAsync();
                Debug.WriteLine("OUTPUT::::::"+Delete);
                Console.WriteLine("OUTPUT::::::"+Delete);
                
                
                //Assert.Equal(true);
                Assert.Equal(resObj,JObject.Parse(Delete));
               // Assert.Empty(result);
             }

          }
    

    }
}