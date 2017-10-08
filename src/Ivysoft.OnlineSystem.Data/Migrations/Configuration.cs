namespace Ivysoft.OnlineSystem.Data.Migrations
{
    using Ivysoft.OnlineSystem.Data.Models;
    using Ivysoft.OnlineSystem.Data.Models.Aspnet;
    using Ivysoft.OnlineSystem.Data.Properties;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public sealed class Configuration : DbMigrationsConfiguration<OnlineSystemDbContext>
    {
        private const string AdministratorUserName = "nayden.kirov@gmail.com";
        private const string AdministratorPassword = "123456";

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(OnlineSystemDbContext context)
        {
            this.SeedUsers(context);

        }
        private void SeedUsers(OnlineSystemDbContext context)
        {
            if (!context.Roles.Any())
            {
                var roleName = "Administrator";
                var roleStore = new RoleStore<ApplicationRole>(context);
                var roleManager = new RoleManager<ApplicationRole>(roleStore);
                var role = new ApplicationRole { Name = roleName };
                roleManager.Create(role);

                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);
                var user = new User
                {
                    UserName = AdministratorUserName,
                    Email = AdministratorUserName,
                    EmailConfirmed = true,
                    CreatedOn = DateTime.Now
                };

                userManager.Create(user, AdministratorPassword);
                userManager.AddToRole(user.Id, roleName);
            }
        }
    }
}
