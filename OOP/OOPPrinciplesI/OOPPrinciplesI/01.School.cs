using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesI
{
  public class School     // Define class school
    {
      public string textBox;      // Define field optional text box
      
      public School(string textBox)   // Constructor for text box
      {
          this.textBox = textBox;
      }
      public School() { }        // empty constructor, in case we don't want to write optional text

      public string TextBox      // Define properties for text box. We don't make any constrains to it
      {
          get { return textBox; }
          set { textBox = value; }
      }

      public override string ToString()    // Print information on the console
      {
          return string.Format("optional text: {0}", textBox);
      }
    }
}
