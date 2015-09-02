using System;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.Runtime;
using System.Collections.Generic;
using System.Linq;
using Test.Context;

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

        [HttpGet("Sum")]
        public int Sum()
        {
            return -1;
        }

        [HttpPost("Add")]
        public void Add([FromBody]string valueToAddStr)
        {
            int value = 0;
            int.TryParse(valueToAddStr, out value);
            TestContext testContext = new TestContext();
            testContext.Additions.Add(new Addition { Id = Guid.NewGuid(), Value = value });
            testContext.SaveChanges();
        }
    }

}
