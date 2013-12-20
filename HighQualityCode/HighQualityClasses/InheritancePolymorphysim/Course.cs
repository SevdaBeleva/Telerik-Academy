using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphysim
{
    public abstract class Course
    {
        private string Name { get; set; }
        public string TeacherName { get; set; }
        public IList<string> Students { get; set; }

        public Course(string courseName)
        {
            this.Name = courseName;
        }

        public Course(string courseName, string teacherName)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
        }

        public Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder buildCourse = new StringBuilder();
            buildCourse.AppendFormat(" {{ Name = {0} ", this.Name);
            if (this.TeacherName != null)
            {
                buildCourse.AppendFormat("; Teacher = {0}", this.TeacherName);
            }
            buildCourse.AppendFormat("; Students = {0} ", GetStudentsAsString());

            return buildCourse.ToString();
        }
    }
}
