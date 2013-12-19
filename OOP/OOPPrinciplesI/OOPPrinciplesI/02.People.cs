using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesI
{
   public class People : School     // People inherits School
    {
        public string name;   // Define field name

       public People(string name, string textBox)   // Constructor using optional text box
           : base(textBox)
       {
           this.Name = name;
       }
       public People(string name)       // Constructor without optional text box
           : base()
       {
           this.Name = name;
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

       public override string ToString()    // Print information on the console
       {
           return string.Format("Name: {0} optional text: {1}", this.name, this.textBox);
       }
    }
}
