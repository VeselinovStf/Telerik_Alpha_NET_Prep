namespace LectureExercise.Forum.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialTwo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Title", c => c.String());
            AddColumn("dbo.Posts", "Content", c => c.String());
            AddColumn("dbo.Posts", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Posts", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.Posts", "CreatedOn", c => c.DateTime());
            AddColumn("dbo.Posts", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.Posts", "Author_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "DeletedOn", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "CreatedOn", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "ModifiedOn", c => c.DateTime());
            CreateIndex("dbo.Posts", "IsDeleted");
            CreateIndex("dbo.Posts", "Author_Id");
            CreateIndex("dbo.AspNetUsers", "IsDeleted");
            AddForeignKey("dbo.Posts", "Author_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUsers", new[] { "IsDeleted" });
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            DropIndex("dbo.Posts", new[] { "IsDeleted" });
            DropColumn("dbo.AspNetUsers", "ModifiedOn");
            DropColumn("dbo.AspNetUsers", "CreatedOn");
            DropColumn("dbo.AspNetUsers", "DeletedOn");
            DropColumn("dbo.AspNetUsers", "IsDeleted");
            DropColumn("dbo.Posts", "Author_Id");
            DropColumn("dbo.Posts", "ModifiedOn");
            DropColumn("dbo.Posts", "CreatedOn");
            DropColumn("dbo.Posts", "DeletedOn");
            DropColumn("dbo.Posts", "IsDeleted");
            DropColumn("dbo.Posts", "Content");
            DropColumn("dbo.Posts", "Title");
        }
    }
}
