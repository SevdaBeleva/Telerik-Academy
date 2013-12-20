namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Models;

    public sealed class Configuration : DbMigrationsConfiguration<SudentSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SudentSystemContext context)
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

            context.Students.AddOrUpdate(new Student { Name = "Aleksei Tolstoi", Number = "AT1234" });
            context.Courses.AddOrUpdate(new Course { Name = "Slice and Dice", Materials = "Video" });
            context.HomeworkTasks.AddOrUpdate
                (new Homework { Content = "Responsive design", TimeSent = "12.04.1997" });
        }
    }
}
