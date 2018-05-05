namespace LectureExercise.Forum.Data.Migrations
{
    using LectureExercise.Forum.Data.Model;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<LectureExercise.Forum.Data.MsSqlDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(LectureExercise.Forum.Data.MsSqlDbContext context)
        {
            this.SeedAdmin(context);
        }

        private void SeedAdmin(MsSqlDbContext context)
        {
            const string AdministratorUserName = "test@test.com";
            const string AdministratorPassword = "123456";

            if (!context.Roles.Any())
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var role = new IdentityRole("Admin");
                roleManager.Create(role);

                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);

                var user = new User
                {
                    UserName = AdministratorUserName,
                    Email = AdministratorUserName,
                    EmailConfirmed = true
                };

                userManager.Create(user, AdministratorPassword);

                userManager.AddToRole(user.Id, "Admin");
            }
        }
    }
}
