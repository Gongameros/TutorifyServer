using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorifyServer.Models.Person;

namespace TutorifyServer.Configuration
{
    public class PersonConfiguration<T>
        : IEntityTypeConfiguration<T> where T : Person
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.DateOfBirth)
                   .HasConversion(
                        v => v.ToDateTime(TimeOnly.MinValue),  // Convert DateOnly to DateTime
                        v => DateOnly.FromDateTime(v));        // Convert DateTime to DateOnly

            builder.Property(e => e.Id)
                   .ValueGeneratedOnAdd();
        }
    }
}
