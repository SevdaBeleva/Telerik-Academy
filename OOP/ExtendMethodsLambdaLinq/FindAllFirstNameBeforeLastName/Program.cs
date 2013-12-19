using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentsLinq;

namespace StudentsLinq2 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Students student1 = new Students("stoqn ", "pavlov", 23);
            Students student2 = new Students("ana", "kojuharova", 25);
            Students student4 = new Students("kamen", "avorov", 22);
            Students student3 = new Students("kamen", "qvorov", 22);
            
            Students[] array = new Students[] { student1, student2, student3, student4 };

            Console.WriteLine("sort array by names");
            Students.FindStudentsByNames(array);

            Console.WriteLine("sort array by age between 18-24");
            Students.FindStudentsByAge(array);

            Console.WriteLine("sort array in descending order using LINQ");
            Students.FindStudentsLinq(array);

            Console.WriteLine("sort array in descending order using lambda expressions");
            Students.FindStudentsOrderByThenBy(array);

        }
    }
}