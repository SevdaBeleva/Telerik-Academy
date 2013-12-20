using System;
using System.Collections.Generic;

namespace InheritancePolymorphysim
{
   public class CoursesExamples
    {
        static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Data");
            localCourse.Lab = "Enterprise";
            localCourse.Students = new List<string>() { "Peter", "Maria" };
            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse.ToString());
           
            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", "Mario Peshev", 
                 new List<string>() { "Thomas", "Ani", "Steve" }, "Sofia");
            Console.WriteLine(offsiteCourse.ToString());
        }
    }
}
