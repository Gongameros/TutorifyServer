using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorifyServer.Models.Person;

namespace TutorifyServer.Configuration
{
    public class TutorConfiguration
        : PersonConfiguration<Tutor>, IEntityTypeConfiguration<Tutor>
    {
        public override void Configure(EntityTypeBuilder<Tutor> builder)
        {
            base.Configure(builder);
        }
    }
}
