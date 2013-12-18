using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.maxSequenceOfEqualElements
{
    class maxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] array = { 2,2,1,1,1};
            int start = 1;
            int length = 1;
            int bestStart = 0;
            int bestLength = 0;

            for (int i = 0; i < array.Length; i++)
            {

                if (i == 0 || array[i] != array[i-1])
                {
                    length = 1;
                    start = i;
                }

                else
                {
                    length++;

                    if (length > bestLength)
                    {
                        bestStart = start;

                        bestLength = length;
                    }
                }
            }

            Console.Write("max sequence of equal elements in an array: ");

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
