namespace WebAppMVC5Template.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAppMVC5Template.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppMVC5Template.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppMVC5Template.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            
            var roles = new List<string>() { "ADMIN", "USER" };
            foreach (var role in roles)
            {
                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole() { Name = role });
            }
            if (!roles.Contains("ADMIN"))
            {
                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole() { Name = "ADMIN" });
            }

            const string admin = "admin@company.com";
            const string adminPassword = "Pass&1234";

            if (!context.Users.Any(u => u.UserName == admin))
            {
                var user = new ApplicationUser()
                {
                    UserName = admin,
                    Email = admin,
                    FirstName = "Martin",
                    LastName = "Dwyer"
                };

                IdentityResult result = userManager.Create(user, adminPassword);
                context.SaveChanges();

                if (result.Succeeded)
                {
                    userManager.AddToRole(user.Id, "ADMIN");
                    context.SaveChanges();
                }

            }

            const string firstUser = "user@company.com";
            const string firstUserPassword = "Pass&1234";

            if (!context.Users.Any(u => u.UserName == firstUser))
            {
                var user = new ApplicationUser()
                {
                    UserName = firstUser,
                    Email = firstUser,
                    FirstName = "Fred",
                    LastName = "Flintstone"
                };

                IdentityResult result = userManager.Create(user, firstUserPassword);
                context.SaveChanges();

                if (result.Succeeded)
                {
                    userManager.AddToRole(user.Id, "USER");
                    context.SaveChanges();
                }

            }
        }
    }
}
