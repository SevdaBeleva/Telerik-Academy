using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program 
    {
        static void Main(string[] args)
        {

            Students student = new Students("ani", "sofieva", "pasi", "12321321",
                new string []{"Plovdiv, " + "Marica " + "12"},
                "0877123456", 
                "sad.21@abv.bg", 2, Specialty.History, University.Plovdiv, Faculty.History);
            Console.WriteLine(student.ToString());

            Students newStudent = new Students();
            newStudent = (Students)student.Clone();
            Console.WriteLine(newStudent.ToString());

            Console.WriteLine(student.GetHashCode());

            Console.WriteLine(student.CompareTo(newStudent));
            
            
        }
    }
}
