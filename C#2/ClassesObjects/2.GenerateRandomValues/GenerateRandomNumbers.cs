using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GenerateRandomValues
{
    class GenerateRandomNumbers
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(randomGenerator.Next(101)+100);
            }
        }
    }
}
