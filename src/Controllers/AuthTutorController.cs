using Microsoft.AspNetCore.Mvc;
using TutorifyServer.Data;
using TutorifyServer.Dtos;
using TutorifyServer.Helpers;
using TutorifyServer.Models.Person;

namespace TutorifyServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthTutorController : ControllerBase
    {
        private readonly IPersonRepository<Tutor> _repository;
        private readonly JwtService _jwtService;

        public AuthTutorController(IPersonRepository<Tutor> repository,
            JwtService jwtService)
        {
            _repository = repository;
            _jwtService = jwtService;
        }

        [HttpPost("sign-up")]
        public IActionResult Register(RegisterDto dto)
        {
            var tutor = new Tutor
            {
                Name = dto.Name,
                Surname = dto.Surname,
                Email = dto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };

            return Created("success", _repository.Create(tutor));
        }

        [HttpPost("sign-in")]
        public IActionResult Login(LoginDto dto)
        {
            Tutor? tutor = _repository.GetByEmail(dto.Email);

            if (tutor == null) return BadRequest(new { message = "Invalid Credentials" });

            if (!BCrypt.Net.BCrypt.Verify(dto.Password, tutor.Password))
            {
                return BadRequest(new { message = "Invalid Credentials" });
            }

            var jwt = _jwtService.Generate(tutor.Id);

            Response.Cookies.Append("jwt", jwt, new CookieOptions
            {
                HttpOnly = true
            });

            return Ok(new
            {
                message = "success"
            });
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];

                var token = _jwtService.Verify(jwt);

                int userId = int.Parse(token.Issuer);

                var user = _repository.GetById(userId);

                return Ok(user);
            }
            catch (Exception)
            {
                return Unauthorized();
            }
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");

            return Ok(new
            {
                message = "success"
            });
        }
    }
}
