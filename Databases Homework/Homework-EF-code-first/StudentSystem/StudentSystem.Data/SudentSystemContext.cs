using System;
using System.Collections.Generic;
using System.Data.Entity;
using StudentSystem.Models;

namespace StudentSystem.Data
{
    public class SudentSystemContext : DbContext
    {
        public SudentSystemContext()
            : base("StudentSystemDb")
        {

        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Homework> HomeworkTasks { get; set; }
    }
}
