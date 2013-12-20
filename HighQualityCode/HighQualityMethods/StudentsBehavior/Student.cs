using System;
using System.Globalization;
using System.Threading;

namespace StudentsBehavior
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //specify single field for example birth date rather than other info
        public string BirthDate { get; set; }

       public Student(string firstName, string lastName, string birthDate)
       {
           this.FirstName = firstName;
           this.LastName = lastName;
           this.BirthDate = birthDate;
       }

       public Student()
       {

       }

       //change the parameter Student to string, so it becomes reusable for another objects or variables
       public static bool IsOlderThan(string firstDate, string secondDate)
       {
           //Specify the current culture for the specific date format
           Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
           DateTime ftrstBirthDate = DateTime.Parse(firstDate);
           DateTime secondBirthDate = DateTime.Parse(secondDate);

           //Notice that older person has smaller year and operrator must be "<", but not ">"
           return ftrstBirthDate < secondBirthDate;
       }
    }
}
