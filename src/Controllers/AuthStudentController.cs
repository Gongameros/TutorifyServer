using Microsoft.AspNetCore.Mvc;

namespace TutorifyServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthStudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Okay");
        }
    }
}
