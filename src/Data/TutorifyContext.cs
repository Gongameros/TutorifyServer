using Microsoft.EntityFrameworkCore;
using TutorifyServer.Models.Person;

namespace TutorifyServer.Data
{
    public class TutorifyContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public TutorifyContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
