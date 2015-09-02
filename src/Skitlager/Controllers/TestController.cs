using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Test.Context;

namespace Test.Controllers
{

    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public string Get()
        {
            TestContext testContext = new TestContext();
            testContext.Additions.Add(new Addition { Id = Guid.NewGuid(), Value = 5 });
            testContext.SaveChanges();

            return "Skeeetlager!";
        }
    }

}