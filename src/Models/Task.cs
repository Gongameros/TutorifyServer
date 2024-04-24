namespace TutorifyServer.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int Price { get; set; }
        public DateOnly Deadline { get; set; }
    }
}
