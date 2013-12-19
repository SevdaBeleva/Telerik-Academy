using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals.cs
{
    class Dog : Animal, ISound
    {
        public Dog(string name, int age, string sex)
            : base(name, age, sex)
        { }
        public string GetSound()
        {
            return "Bauuuuu!";
        }
    }
}
