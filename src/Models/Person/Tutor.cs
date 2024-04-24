namespace TutorifyServer.Models.Person
{
    public class Tutor : Person
    {
        public string[] Subjects { get; set; }
        public string About { get; set; }
        public string Education { get; set; }
        public float YearExperience { get; set; }
    }
}
