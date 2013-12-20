using System;
using System.Collections.Generic;
using StudentSystem.Models;
using StudentSystem.Data;
using System.Data.Entity;
using StudentSystem.Data.Migrations;


namespace StudentSystem.Client
{
   static class Program
    {
       static void Main(string[] args)
       {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion
               <SudentSystemContext, Configuration>());

           var dbContext = new SudentSystemContext();
           var student = new Student { Name = "Aleksei Tolstoi", Number = "AP123465" };
           var course = new Course { Name = "Slice and Dice", Materials = "Video" };
           var homework = new Homework { Student = student, Course = course };

           dbContext.Students.Add(student);
           dbContext.Courses.Add(course);
           dbContext.HomeworkTasks.Add(homework);
       }
        
    }
}
