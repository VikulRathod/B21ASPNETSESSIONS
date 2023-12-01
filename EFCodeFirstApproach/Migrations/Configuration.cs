namespace EFCodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirstApproach.Models.B21CodeFirstDBContext>
    {
        public Configuration()
        {            
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFCodeFirstApproach.Models.B21CodeFirstDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Courses.Add(new Models.Course() 
            { Id=1, Name = "Dot Net", DurationInMonths = 6, Fees = 50000});

            context.SaveChanges();
        }
    }
}
