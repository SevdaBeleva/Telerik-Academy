using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.AllocateArray20x5
{
    class AllocateArray20x5
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]*5);
            }
        }
    }
}
