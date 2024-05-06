using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NSwagMSBuildSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DummyController : ControllerBase
    {
        [ProducesResponseType(200, Type = typeof(string))]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }
    }
}
