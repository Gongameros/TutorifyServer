using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorifyServer.Models.Person;

namespace TutorifyServer.Configuration
{
    public class StudentConfiguration
        : PersonConfiguration<Student>, IEntityTypeConfiguration<Student>
    {
        public override void Configure(EntityTypeBuilder<Student> builder)
        {
            base.Configure(builder);
        }
    }
}
