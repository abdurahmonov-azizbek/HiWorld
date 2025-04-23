using Microsoft.AspNetCore.Mvc;

namespace HiWorld.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HiWorld : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Hi() => Ok("Hi World:)");
    }
}
