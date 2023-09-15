using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Middlewares.Configuration.Filters;

namespace Middlewares.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [MyActionFilter("DriversController")]
    
    public class DriversController : ControllerBase
    {
        private static List<string> drivers= new List<string>()
        {
            "noor",
            "maram",
            "assaf"
        };
        [HttpGet(Name ="Get")]
        public ActionResult<List<string>> Get()
        {
            if (drivers is null) return NotFound();
            return Ok(drivers);
        }

        [HttpPost(Name = "add")]
        [MyActionFilter("DriversController-Add Action")]
        [MyAsyncActionFilter("DriversController-Add Action Async",10)]
        [MySecondAsyncActionFilter("DriversController-Add Action Async 2")]
        public IActionResult add( string driver)
        {
            return Ok(drivers);
        }
    }
}
