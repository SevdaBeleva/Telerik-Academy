using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesI
{
  public class Classes : School           // Classes inherits School
    {
      private string idNumber;           // Define field id number
      public List<Teachers> listTeachers { get; set; }    // Define field list of teachers
      public List<Student> listStudents { get; set; }

        public Classes (string idNumber, string textBox,  List<Teachers> listTeachers, List<Student> listStudents) : base (textBox)  // Constructor using optional text box
        {
            this.idNumber = idNumber;
            this.listTeachers = listTeachers;
            this.listStudents = listStudents;
        }

        public Classes(string idNumber, List<Teachers> listTeachers, List<Student> listStudents)   // Constructor wihtout optional text box
            : base()
        {
            this.IDNumber = idNumber;
            this.listTeachers = listTeachers;
            this.listStudents = listStudents;
        }

        public string IDNumber            // Define properties for id number, encapsulate, throw exception
        {
            get { return this.idNumber; }
            set
            {
                this.idNumber = value;
                if (int.Parse(idNumber) < 0)
                {
                    throw new ArgumentException("ID number should not be negative number!");
                }
            }
        }

        public static string PrintTeachers(List<Teachers> listTeachers)           // Print list of teachers on the console
        {
            StringBuilder listTeachersBuilder = new StringBuilder();
            
            foreach (Teachers teacher in listTeachers)        // loop for printing students
            {
                listTeachersBuilder.AppendFormat("Teachers: {0}" + "\n", teacher);
            }
            return listTeachersBuilder.ToString();        
        }

        public static string PrintStudents(List<Student> listStudents)           // Print list of students on the console
        {
            StringBuilder listStudentsBuilder = new StringBuilder();
            foreach (Student student in listStudents)        // loop for printing students
            {
                listStudentsBuilder.AppendFormat("Students: {0}" + "\n", student);
            }
            return listStudentsBuilder.ToString();
        }
        public override string ToString()             // Print all info for the class
        {
            StringBuilder buildClass = new StringBuilder();
            buildClass.AppendFormat("Class" + "\n" + "Unique text identifier: {0}" + "\n" + "{1}" + "\n" + "{2}" + 
                "\n", this.idNumber, PrintTeachers(listTeachers), PrintStudents(listStudents));
            return buildClass.ToString();
        }
        
    }
}
