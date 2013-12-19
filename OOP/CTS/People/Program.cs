using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            // test the functionality for unspecified type
            Person person = new Person("aleks", null);
            Console.WriteLine(person);
        }
    }
}
