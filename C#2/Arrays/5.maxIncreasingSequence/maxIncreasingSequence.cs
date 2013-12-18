using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.maxIncreasingSequence
{
    class maxIncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 34, 56, 12, 13, 14, 15 };
            int length = 1;
            int bestLength = 0;
            int lastIndex = 0;
  
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    length++;
                }
                else
                {
                    if (length > bestLength)
                    {
                        bestLength = length;
                        lastIndex = i;
                    }
                    length = 1;
                }
            }
            Console.Write("max sequence of increasing elements: ");
            for (int i = lastIndex - bestLength + 1; i < lastIndex + 1; i++)
            {
                Console.Write( array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
