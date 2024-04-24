using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TutorifyServer.Models.Person
{
    public abstract class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly DateOfBirth { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
}
