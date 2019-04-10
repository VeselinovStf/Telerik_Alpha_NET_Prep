using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Data.Config;
using MovieSystem.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MovieSystem.Data
{
    public class MovieSystemDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public MovieSystemDbContext(DbContextOptions<MovieSystemDbContext> options) 
            : base(options)
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
