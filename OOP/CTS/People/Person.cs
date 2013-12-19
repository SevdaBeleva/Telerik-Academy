using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    // task 4 - Create a class Person with two fields – name and age. Age can be left unspecified 
    //(may contain null value. Override ToString() to display the information of a person 
    //and if age is not specified – to say so. Write a program to test this functionality.

    class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age)  // create a constructor
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name   // define property for name field
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("name field should not be empty!");
                this.name = value;
            }
        }

        public int? Age   // create property for age field
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public override string ToString()   // display info about an object of class Person
        {
            return string.Format("name: {0}" + "\n" + "age: {1}", 
                this.name, 
                // check if age is unspecified
                this.age != null ? this.age.ToString() : "age is not specified" ); 
        }
    }
}
