using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private const byte MaxStudents = 30;
        private readonly IList<Student> listOFStudents;
        private String courseName;

        public Course(string courseName)
        {
            this.CourseName = courseName;
            this.listOFStudents = new List<Student>(MaxStudents);
        }

        public String CourseName
        {
            get
            {
                return this.courseName;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Course name can't be null or empty.");
                }
                this.courseName = value;
            }
        }

        public void AddStudent(Student currentStudent)
        {
            if (listOFStudents.Count == MaxStudents)
            {
                throw new ArgumentException("Course is full, there is no place for new students.");
            }

            if (currentStudent == null)
            {
                throw new ArgumentNullException("You cannot add a null student into the course");
            }

            if (IsAlreadyEnrolledInCourse(currentStudent))
            {
                throw new ArgumentException(String.Format("The student with id - {0}, is already enrolled in {1}",
                    currentStudent.UniqueID, CourseName));
            }

            listOFStudents.Add(currentStudent);

        }

        public void RemoveStudentByID(uint currentStudentID)
        {
            if (currentStudentID < 10000 || 99999 < currentStudentID)
            {
                throw new ArgumentOutOfRangeException("Use valid ID in range of [10000..99999] for removing student");
            }

            bool isFound = false;

            foreach (var item in listOFStudents)
            {
                if (item.UniqueID == currentStudentID)
                {
                    listOFStudents.Remove(item);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                throw new ArgumentException("The student with the given ID is not found in this course.");
            }
        }

        private bool IsAlreadyEnrolledInCourse(Student currentStudent)
        {
            foreach (var item in listOFStudents)
            {
                if (currentStudent.UniqueID == item.UniqueID)
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var item in listOFStudents)
            {
                result.Append(item + Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
