using Microsoft.AspNet.TestHost;

namespace EmployeeWebApiIntegrationTest.Test
{
     public class BaseTestController

    {
        public  readonly TestServer _server;

        public  BaseTestController()
        {
            _server = new TestServer(TestServer.CreateBuilder().UseStartup<Startup>());
        }
    }
}