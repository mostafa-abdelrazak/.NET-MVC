using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_lab_3___4.Models;

namespace MVC_lab_3___4.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
            builder.Property(c =>c.Age).IsRequired();

        }
    }
}
