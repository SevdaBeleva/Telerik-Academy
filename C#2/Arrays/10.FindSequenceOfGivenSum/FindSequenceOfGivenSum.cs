using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSequenceOfGivenSum
{
    class FindSequenceOfGivenSum
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int[] array = {4,3,1,4,2,5,8};
            

            for (int i = 0; i < array.Length; i++)
            {
                int currentSum = 0;
                for (int j = i; j < array.Length; j++)
                {
                    currentSum = currentSum + array[j];
                    int lastIndex = j - i + 1;
                    if (currentSum == s)
                    {
                        for (int print = 0; print < lastIndex; print++)
                        {
                            Console.WriteLine(array[i+print]);
                        }
                    }
                }
            }
            
                
            
           
            
            
        }
    }
}
