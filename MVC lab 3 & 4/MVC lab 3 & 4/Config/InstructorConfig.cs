using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_lab_3___4.Models;

namespace MVC_lab_3___4.Config
{
    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);   
        }
    }
}
