using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphysim
{
    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town) 
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName) : base (courseName)
        {

        }

        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {

        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {

        }

        public string Town
        {
            get { return town; }
            set
            {
                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder buildOffsiteCourse = new StringBuilder();
            buildOffsiteCourse.AppendFormat("{0} ", this.GetType().Name);
            buildOffsiteCourse.AppendFormat("{0}", base.ToString());
            buildOffsiteCourse.AppendFormat("Town = {0}", this.Town);
            buildOffsiteCourse.AppendFormat("}}");

            return buildOffsiteCourse.ToString();
        }
    }
}
