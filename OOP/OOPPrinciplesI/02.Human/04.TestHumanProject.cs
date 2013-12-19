using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create 10 objects of type Worker class
            Worker one = new Worker(900, 40, "Gosho", "Petrov");
            Worker two = new Worker(760, 40, "Ivan", "Ivanov");
            Worker three = new Worker(500, 25, "Galin", "Ivanov");
            Worker four = new Worker(360, 35, "Stoyan", "Georgiev");
            Worker five = new Worker(1200, 60, "Viktor", "Georgiev");
            Worker six = new Worker(520, 35, "Albert", "Atanasov");
            Worker seven = new Worker(360, 35, "Stoyan", "Georgiev");
            Worker eight = new Worker(480, 30, "Evlogi", "Petrov");
            Worker nine = new Worker(2100, 50, "Ivan", "Simonov");
            Worker ten = new Worker(950, 25, "Atanas", "Zaprqnov");

            // Create list of the previous 10 objects
            List<Worker> listWorker = new List<Worker>();
            listWorker.Add(one);
            listWorker.Add(two);
            listWorker.Add(three);
            listWorker.Add(four);
            listWorker.Add(five);
            listWorker.Add(six);
            listWorker.Add(seven);
            listWorker.Add(eight);
            listWorker.Add(nine);
            listWorker.Add(ten);

            // Sort the list if workers using lambda expression
            listWorker = listWorker.OrderByDescending(worker => worker.MoneyPerHour()).ToList();
            Console.WriteLine("List of workers sorted by money per hour in descending order: " + "\n");
            StringBuilder buildWorkers  = new StringBuilder();
            foreach (Worker worker in listWorker)
            {
                buildWorkers.AppendFormat("{0}" + "\n", worker);
            }
            Console.WriteLine(buildWorkers);

            // Sort the list of wotkers using LINQ
            /*var sortedWorkers = from worker in listWorker orderby worker.MoneyPerHour() select worker;
            foreach (var worker in listWorker)
            {
                Console.WriteLine(worker);
            }*/


            // Create list of students
            List<Students> listStudents = new List<Students>()
            {
                new Students(5, "Gotse", "Delchev"),
                new Students( 6, "Ivan", "Ivanov"),
                new Students(3, "Emil", "Ganchev"),
                new Students(6, "Stoio", "Avatarov"),
                new Students(4, "Binka", "Binkova"),
                new Students(6, "Hristo", "Stankov"),
                new Students(5, "Gotse", "Delchev"),
                new Students(6, "Petyr", "Iordanov"),
            };

            // Sort students using lambda expression
           listStudents = listStudents.OrderBy(student => student.Grade).ToList();
           Console.WriteLine("List of student ordered by drade in ascending order: " + "\n");
           StringBuilder buildStudents = new StringBuilder();
           // Print students
           foreach (Students student in listStudents)
           {
               buildStudents.AppendFormat("{0}" + "\n", student);
           }
           Console.WriteLine(buildStudents);
            // Sort students using LINQ
           /*var sortedStudents = from student in listStudents orderby student.grade select student;
           foreach (var student in sortedStudents)
           {
               Console.WriteLine(student);
           }*/
           
            
            // merge lists and sort them by first name and last name

           var mergedLists = listStudents.Concat<Human>(listWorker).ToList();
           mergedLists = mergedLists.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();
           StringBuilder buildLists = new StringBuilder();

           foreach (var item in mergedLists)
           {
               buildLists.AppendFormat(item.FirstName + " " + item.LastName + "\n");
           }
           Console.WriteLine(buildLists);
        }
    }
}