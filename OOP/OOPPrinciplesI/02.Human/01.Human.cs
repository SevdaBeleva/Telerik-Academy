using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Human
{
    public abstract class Human  // Create abstract class human
    {
        public string FirstName {get; set;}      // define properties
        public string LastName { get; set;}      // define properties

        public Human (string FirstName, string LastName)   // define a constructor
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public override string ToString()     // Override ToString
        {
            return string.Format("First name: {0}" + "\n" + "Last name: {1}", this.FirstName, this.LastName);
        }
    }
  
  
}
