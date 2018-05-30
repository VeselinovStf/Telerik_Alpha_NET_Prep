namespace EFCodeFirst.CLI.Engine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Makers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DeliveryTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Type = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductMakers",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Maker_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Maker_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Makers", t => t.Maker_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Maker_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductMakers", "Maker_Id", "dbo.Makers");
            DropForeignKey("dbo.ProductMakers", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductMakers", new[] { "Maker_Id" });
            DropIndex("dbo.ProductMakers", new[] { "Product_Id" });
            DropTable("dbo.ProductMakers");
            DropTable("dbo.Products");
            DropTable("dbo.Makers");
        }
    }
}
