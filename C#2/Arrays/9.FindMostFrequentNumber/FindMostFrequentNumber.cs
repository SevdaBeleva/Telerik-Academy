using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.FindMostFrequentNumber
{
    class FindMostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 4, 4, 4, 4, 3, 7, 6, 4, 1, 4, 9, 3, };
            int count = 0;
            int maxCount = 0;
            int maxNum = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                count = 0;
                for (int j = i + 1; j < array.Length; j++ )
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxNum = array[i];
                    }     
            }
            Console.WriteLine("{0} -> {1} times", maxNum, maxCount +1);
            
        }
    }
}
