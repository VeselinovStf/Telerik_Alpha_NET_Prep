using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace UniversiteySystem.Data
{
    public class UniversitySystemDbContext : DbContext
    {      
        public UniversitySystemDbContext()
        {

        }
        public UniversitySystemDbContext(DbContextOptions<UniversitySystemDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
