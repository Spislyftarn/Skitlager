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
            TestContext testContext = new TestContext();
            testContext.Additions.Add(new Addition { Id = Guid.NewGuid(), Value = 5 });
            testContext.SaveChanges();

            string toReturn = "Skeeeetlager: " + _appEnvironment.ApplicationBasePath;
            return toReturn;
        }
    }

}
