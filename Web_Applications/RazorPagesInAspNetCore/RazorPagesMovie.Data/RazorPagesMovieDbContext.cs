using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data.Config;
using RazorPagesMovie.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public RazorPagesMovieDbContext()
        {

        }
        public RazorPagesMovieDbContext(DbContextOptions<RazorPagesMovieDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieConfig());

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
