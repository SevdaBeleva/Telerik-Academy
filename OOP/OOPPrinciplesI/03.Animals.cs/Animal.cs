using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Animals
{
    public class Animal 
    {
        private string name;
        private int age;
        private string sex;

        public Animal(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex; 
        }

        public string Name
        {
            get { return this.name; }
            set {
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set{
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("name: {0}" + "\n" + "age: {1}" + "\n" + "sex: {2}", this.name, this.age, this.sex);
        }


        public static double GetAverageAge(IEnumerable<Animal> list)
        {
            double sum = 0;
            int count = 0;

            foreach (Animal animal in list)
            {
                sum += animal.Age;
                count++;
            }
            if (sum == 0)
            {
                throw new ArgumentException("The list of animals does not contains animals!");
            }
            else
            {
                return sum / count;
            }
        }
    }
}
