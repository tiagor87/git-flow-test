using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("hello-world")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult HelloWorld([FromQuery] string name = "World") => Ok($"Hello {name}");
    }
}
