using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesI
{
   public class TestClass
    {
        static void Main(string[] args)
        {
            Disciplines biology = new Disciplines("Biology", 5, 5, "1 exam");  // new object of Discipline class
            biology.Name = "scientific biology";   // try to set new values to biology
            biology.Lectures = -5;
            biology.Exercizes = 7;

            Disciplines chemistry = new Disciplines("chemistry", 3, 10);   // new object of Discipline class

            Disciplines geography = new Disciplines("geography", 12, 12, "beautiful geography");  // new object of Discipline class

            List<Disciplines> list = new List<Disciplines>();   // create list of objects from Discipline class
            list.Add(biology);
            list.Add(chemistry);
            list.Add(geography);

            Teachers teacher = new Teachers("Ivan","sasasa", list);  // create new object of Teachers class
            List<Teachers> listTeachers = new List<Teachers>();    // create list of objects from Teachers class
            listTeachers.Add(teacher);

            Student student = new Student("Pesho", "1234", "i am hot");  // create new object of Student class
            List<Student> listSt = new List<Student>();          // create list of objects from Student class
            listSt.Add(student);

            Classes firstClass = new Classes("A","saadsa", listTeachers, listSt); // create object of Classes class
            Console.WriteLine(firstClass);     // Print on the console all info for this class

            //Console.WriteLine( Classes.PrintStudents(listSt));   // you can print info only about students, just uncomment the code
           //Console.WriteLine(Classes.PrintTeachers(listTeachers));  // you can print info only about teachers, just uncomment the code
        }
    }
}
