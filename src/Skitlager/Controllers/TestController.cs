using Microsoft.AspNet.Mvc;
using Microsoft.Framework.Runtime;
using System.Collections.Generic;

namespace Test.Controllers
{

    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly IApplicationEnvironment _appEnvironment;

        public TestController(IApplicationEnvironment environment)
        {
            _appEnvironment = environment;
        }

        [HttpGet]
        public string Get()
        {
            string toReturn = "Skeeeetlager: " + _appEnvironment.ApplicationBasePath;
            return toReturn;
        }
    }

}
