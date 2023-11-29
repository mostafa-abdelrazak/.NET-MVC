using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_lab_3___4.Models;

namespace MVC_lab_3___4.Config
{
    public class StudentCouresConfig : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(c => new{ c.StudentId, c.CourseId});
            
        }
    }
}
