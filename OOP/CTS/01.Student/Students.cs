using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student 
{
   public enum Specialty
    { 
        Ethnology, Anthropology, Biology, History, HumanInformatics
    }

   public enum University
    {
        Plovdiv, Bourgas, Sofia, Varna
    }

   public enum Faculty
    {
        History, Philosophy, Math, Informatics
    }

  // task 1 
  public class Students : ICloneable, IComparable<Students>
    {
      private string firstName {get; set;}
      private string middleName { get; set; }
      private string lastName { get; set; }
      private string SSN { get; set; }
      private string [] permanentAddress { get; set; }
      private string mobilePhone { get; set; }
      private string email { get; set; }
      private int course { get; set; }
      private Specialty specialty { get; set; }
      private University university { get; set; }
      private Faculty faculty { get; set; }
     
      public Students(string firstName, string middleName, string lastName, string SSN, string [] permanentAddress,
          string mobilePhone, string email, int course, Specialty specialty, University university, Faculty faculty)
      {
          this.firstName = firstName;
          this.middleName = middleName;
          this.lastName = lastName;
          this.SSN = SSN;
          this.permanentAddress = permanentAddress;
          this.mobilePhone = mobilePhone;
          this.email = email;
          this.course = course;
          this.specialty = specialty;
          this.university = university;
          this.faculty = faculty;
      }

      public Students()   // Empty constructor for the new class Students where we do deep clone
      {
 
      }

      // override System.Pbject: Equals()
      public override bool Equals(object param)
      {
          Students student = param as Students;

          if (student == null)
          {
              return false;
          }

          if (!Object.Equals(this.firstName, student.firstName))
          {
              return false;
          }

          if (this.SSN != student.SSN)
          {
              return false;
          }
          return true;
      }

      // override System.Pbject: ToString()
      public override string ToString()
      {
        StringBuilder buildStudentInfo = new StringBuilder();
          
        buildStudentInfo.AppendFormat("first name: {0}" + "\n", this.firstName);
        buildStudentInfo.AppendFormat("middle name: {0}" + "\n", this.middleName);
        buildStudentInfo.AppendFormat("last name: {0}" + "\n", this.lastName);
        buildStudentInfo.AppendFormat("SSN: {0}" + "\n", this.SSN);
        buildStudentInfo.AppendFormat("permanent address: {0}" + "\n", this.permanentAddress);
        buildStudentInfo.AppendFormat("mobile phone: {0}" + "\n", this.mobilePhone);
        buildStudentInfo.AppendFormat("email: {0}" + "\n", this.email);
        buildStudentInfo.AppendFormat("course: {0}" + "\n", this.course);
        buildStudentInfo.AppendFormat("specialty: {0}" + "\n", this.specialty);
        buildStudentInfo.AppendFormat("university: {0}" + "\n", this.university);
        buildStudentInfo.AppendFormat("faculty: {0}" + "\n", this.faculty);

        return buildStudentInfo.ToString();
      }

      // override System.Pbject: GetHashCode()
      public override int GetHashCode()
      {
          return lastName.GetHashCode() ^ course.GetHashCode();
      }

      // override System.Pbject: operator ==
      public static bool operator == (Students student1, Students student2)
      {
          return Students.Equals(student1, student2);
      }

      // override System.Pbject: operator !=
      public static bool operator != (Students student1, Students student2)
      {
          return !(Students.Equals(student1, student2));
      }


      // task 2 Add implementations of the ICloneable interface. 
      // The Clone() method should deeply copy all object's fields into a new object of type Student.
      public object Clone()
      {
          Students obj = new Students();
          obj.firstName = (string) this.firstName.Clone();
          obj.middleName = (string) this.middleName.Clone();
          obj.lastName = (string)this.lastName.Clone();
          obj.SSN = (string) this.SSN.Clone();
          obj.permanentAddress = (string []) this.permanentAddress.Clone();
          obj.mobilePhone = (string) this.mobilePhone.Clone();
          obj.email = (string)this.email.Clone();
          obj.course = this.course;
          obj.specialty = this.specialty;
          obj.university = this.university;
          obj.faculty = this.faculty;

          return obj;
      }

     //task 3 Implement the  IComparable<Student> interface to compare students by names(as first criteria, in lexicographic order)
      //and by social security number (as second criteria, in increasing order).
      public int CompareTo(Students other)
      {
          if (firstName.CompareTo(other.firstName) != 0)
          {
              return firstName.CompareTo(other.firstName);
          }

          else if (middleName.CompareTo(other.middleName) != 0)
          {
              return middleName.CompareTo(other.middleName);
          }

          else if (lastName.CompareTo(other.lastName) != 0)
          {
              return lastName.CompareTo(other.lastName);
          }

          else 
          {
              return SSN.CompareTo(other.SSN);
          }
      }

    }
}
