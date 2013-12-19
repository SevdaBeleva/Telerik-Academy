using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesI
{
  public  class Student : People        // Student inherits People
    {
       private string id;                      // Define filed id

       public Student(string name, string id, string textBox)   // Constructor using optional text box
           : base(name, textBox)
       {
           this.id = id;
       }

       public Student(string name, string id)       // Constructor without optional text box 
           : base(name)
       {
           this.id = id;
       }

        public string Id                        // Define properties for id, encapsulate, throw exception
        {
            get { return this.id; }
            set
            {
                this.id = value;
                if (id == null || int.Parse(id)< 0)
                {
                    throw new ArgumentException("ID should not be empty! ID should not be a negative number!");
                }
            }
        }

        public override string ToString()      // Print inforamtion on the console
        {
            return string.Format("\n" + "name: {0}" + "\n" + "id: {1}" + "\n" + "optional text: {2}", this.name, this.id, this.textBox);
        }


        
    }
}
