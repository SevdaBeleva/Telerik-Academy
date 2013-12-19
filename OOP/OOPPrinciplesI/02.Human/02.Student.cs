using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human 
{
    public class Students : Human      // create class students which is derived from human
    {
        public int grade;

        public Students (int grade, string FirstName, string LastName) : base ( FirstName, LastName ) // define a constructor
        {
            this.Grade = grade;
        }

        public int Grade      // define property for grade 
        {
            get { return this.grade; }
            set
            {
                if (this.grade < 0)    // check if grade is a negative number
                {
                    throw new ArgumentException("Grade must not be 0 ot negative number");
                }
                this.grade = value;
            }
        }

        public override string ToString()    // Print info on the console
        {
            return string.Format("\n"+ "{0}"+"\n"+ "grade: {1}", base.ToString(), this.grade);
        }
        
    }
}
