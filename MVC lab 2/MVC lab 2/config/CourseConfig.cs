using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_lab_2.Models;

namespace MVC_lab_2.config
{
    public class CourseConfig : IEntityTypeConfiguration<Course>

    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.Name).HasMaxLength(20).IsRequired();
        }
    }
}
