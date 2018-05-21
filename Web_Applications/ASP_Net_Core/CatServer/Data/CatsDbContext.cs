using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatServer.Data
{
    public class CatsDbContext :DbContext
    {

        public CatsDbContext(DbContextOptions<CatsDbContext> options): base(options)
        {

        }

        public DbSet<Cat> Cats { get; set; }
    }
}
