using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public class Course
    {
        public ICollection<Student> students;

        public Course()
        {
            this.students = new HashSet<Student>();
        }

        public int CourseId { get; set; }

        public string Name { get; set; }

        public string Materials { get; set; }

        public int StudentId { get; set; }

        public virtual ICollection<Student> Students
        {
            get { return students; }

            set { students = value; }
        }
    }
}
