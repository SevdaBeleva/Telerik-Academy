using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals.cs
{
    class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age, string sex)
            : base(name, age, "male")
        { }
        public string  GetSound()
        {
            return "Mrrrrrrrrr!";
        }
    }
}
