using EFCodeFirst.CLI.Engine.Migrations;
using Store.Models;
using System.Data.Entity;

namespace EFCodeFirst.CLI.Engine.StoreProject.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext()
            : base("StoreConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreDbContext, Configuration>());
        }

        public IDbSet<Maker> Makers { get; set; }
        public IDbSet<Product> Products { get; set; }
        //public IDbSet<ProductType> ProductTypes { get; set; }
    }
}
