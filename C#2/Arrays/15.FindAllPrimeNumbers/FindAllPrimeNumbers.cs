using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FindAllPrimeNumbers
{
    class FindAllPrimeNumbers
    {
        static void Main(string[] args)
        {
            
            bool[] array = new bool[10000000 + 1];

            for (int i = 2; i * i <= array.Length; i++)
            {

                if (array[i] == false)
                {
                    for (int j = i * i; j < array.Length; j = j+i)
                    {
                        array[j] = true;
                    }
                }
            }

            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] == false)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
