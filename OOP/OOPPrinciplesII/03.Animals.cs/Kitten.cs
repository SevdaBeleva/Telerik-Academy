using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals.cs
{
    class Kitten : Cat, ISound
    {
        public Kitten(string name, int age, string sex)
            : base(name, age, "female")
        { }

        public string GetSound ()
        {
            return "Miaaauuu!";
        }
    }
}
