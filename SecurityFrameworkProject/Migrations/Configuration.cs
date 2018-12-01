namespace SecurityFrameworkProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SecurityFrameworkProject.Models.SecurityFrameworkProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        //Seed method is not needed in production
        protected override void Seed(SecurityFrameworkProject.Models.SecurityFrameworkProjectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
