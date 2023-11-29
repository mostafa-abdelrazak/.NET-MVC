using Microsoft.EntityFrameworkCore;
using MVC_lab_2.config;

namespace MVC_lab_2.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Test> Tests { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=mvclab2;Trusted_Connection=true;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Course>(new CourseConfig());
            modelBuilder.ApplyConfiguration<Student>(new StudentConfig());
            modelBuilder.ApplyConfiguration<Instructor>(new InstructorConfig());
            modelBuilder.ApplyConfiguration<Test>(new TestConfig());
            base.OnModelCreating(modelBuilder);
        }

    }
}
