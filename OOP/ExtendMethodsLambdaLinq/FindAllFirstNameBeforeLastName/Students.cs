using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsLinq
{
    public class Students        // Define class Students
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private int Age { get; set; }

        public Students(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Age = age;
        }

        public static void FindStudentsByNames(Students[] array)  //task 3: Write a method that from a given array of students finds all 
                                            //students whose first name is before its last name alphabetically. Use LINQ query operators.

        {
            var wantedStudents = from students in array
                                 where students.firstName.CompareTo(students.lastName) == -1
                                 select students;
            foreach (var students in wantedStudents)
            {
                Console.WriteLine("{0} {1}", students.firstName, students.lastName);
            }
            Console.WriteLine();
        }

        public static void FindStudentsByAge(Students[] array)    // task 4: Write a LINQ query that finds the first name and last name
                                                                  //of all students with age between 18 and 24.
        {
            var wantedStudents = from students in array
                                 where (students.Age > 18 && students.Age < 24)
                                 select students;

            foreach (var students in wantedStudents)
            {
                Console.WriteLine("{0} {1} {2}", students.firstName, students.lastName, students.Age);
            }
            Console.WriteLine();
        }

        public static void FindStudentsOrderByThenBy(Students[] array)  // task 5: Using the extension methods OrderBy() and ThenBy() 
                                                                       //with lambda expressions sort the students by first name 
                                                                      //and last name in descending order. Rewrite the same with LINQ.

        {
          var  newArray = array.OrderByDescending(x => x.firstName).ThenByDescending(x => x.lastName).ToList();
          foreach (var students in newArray)
          {
              Console.WriteLine("{0} {1}", students.firstName, students.lastName);
          }
          Console.WriteLine();
        }

        public static void FindStudentsLinq(Students[] array)   // task 5a: Using the extension methods OrderBy() and ThenBy() 
                                                                       //sort the students by first name 
                                                                      //and last name in descending order. Use LINQ.
        {
            var wantedStudents = from students in array
                                 orderby students.lastName descending
                                 orderby students.firstName descending

                                 select students;
            foreach (var students in wantedStudents)
            {
                Console.WriteLine("{0} {1}" , students.firstName, students.lastName);
            }
            Console.WriteLine();
        }
    }
}