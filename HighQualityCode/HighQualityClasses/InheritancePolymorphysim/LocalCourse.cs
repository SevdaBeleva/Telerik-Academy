using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphysim
{
    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string courseName, string lab,string teacherName, IList<string> students) 
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public LocalCourse(string courseName) : base (courseName)
        {
            
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {

        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {

        }

        public string Lab
        {
            get { return lab; }
            set
            {
                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder buildLocalCourse = new StringBuilder();
            buildLocalCourse.AppendFormat("{0}", this.GetType().Name);
            buildLocalCourse.AppendFormat("{0}", base.ToString());
            buildLocalCourse.AppendFormat("Lab = {0}", this.Lab);
            buildLocalCourse.AppendFormat("}}");

            return buildLocalCourse.ToString();
        }
    }
}
