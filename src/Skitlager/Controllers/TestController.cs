using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

namespace Test.Controllers
{

    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Skeeetlager!";
        }
    }

}