namespace ManageUser.Migrations
{
    using ManageUser.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManageUser.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ManageUser.Models.ApplicationDbContext";
        }

        protected override void Seed(ManageUser.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var role = new IdentityRole() { Name = "Admin" };

                roleManager.Create(role);
            }

            if (!context.Users.Any(p=>p.UserName == "estee@estee.com"))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(userStore);
                var user = new ApplicationUser() { Email = "estee@estee.com", UserName = "estee@estee.com" };

                manager.Create(user, "Password@1");
                manager.AddToRole(user.Id, "Admin");
            }
        }
    }
}
