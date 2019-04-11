using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using UniversiteySystem.Data.Config;
using UniversitySystem.Models.Entities;

namespace UniversiteySystem.Data
{
    public class UniversitySystemDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Course> Courses { get; set; }

        public UniversitySystemDbContext()
        {

        }
        public UniversitySystemDbContext(DbContextOptions<UniversitySystemDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new EnrollmentConfig());
            modelBuilder.ApplyConfiguration(new CourseConfig());

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
