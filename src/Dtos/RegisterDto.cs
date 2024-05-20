using System.ComponentModel.DataAnnotations;

namespace TutorifyServer.Dtos
{
    public class RegisterDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
