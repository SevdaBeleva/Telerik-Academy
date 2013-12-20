using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        public ICollection<Course> courses;

        public Student()
        {
            this.courses = new HashSet<Course>();
        }
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return courses; }

            set { courses = value; }
        }
    }
}
