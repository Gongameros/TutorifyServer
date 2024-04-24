using Microsoft.AspNetCore.Mvc;

namespace TutorifyServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthTeacherController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Okay");
        }
    }
}
