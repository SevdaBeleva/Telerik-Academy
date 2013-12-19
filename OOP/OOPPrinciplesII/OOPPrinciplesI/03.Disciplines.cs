using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesI
{
    public class Disciplines : School    // Disciplines inherits School
    {
        private string name;            // Define fields name, lectures, exercizes
        private int lectures;
        private int exercizes;

        public Disciplines( string name, int lectures, int exercizes, string textBox) // Constructor using optional text box
            : base(textBox)   
        {
       
            this.Name = name;
            this.Lectures =  lectures;
            this.Exercizes = exercizes;
        }

        public Disciplines(string name, int lectures, int exercizes)         // Constructor without optional text box 
            : base()
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercizes = exercizes;
        }

        public string Name                  // Define properties for name, encapsulate, throw exception
        {
            get { return this.name; }
            set
            {
                this.name = value;
                if (String.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Name field should not be empty!");
                }
                
            }
        }
        public int Lectures               // Define properties for lectures, encapsulate, throw exception
        {
            get { return this.lectures; }
            set 
            {
                
                if (value < 0)
                {
                    throw new ArgumentException("Lectures sholud not be a negative number!");
                }
                this.lectures = value;
            }
        }

        public int Exercizes              // Define properties for exercizes, encapsulate, throw exception
        {
            get { return this.exercizes; }
            set
            {
                this.exercizes = value;
                if (exercizes < 0)
                {
                    throw new ArgumentException("Exersizes sholud not be a negative number!");
                }
            }
        }
        public override string ToString()      // Print inforamtion on the console
        {
            return string.Format("{0}" +"\n" +"Lectures: {1}" + "\n" + "Exercizes: {2}" + "\n" + "Optional text: {3}" + "\n" + "\n", this.name, this.lectures, this.exercizes, this.textBox);
        }
    }
}
