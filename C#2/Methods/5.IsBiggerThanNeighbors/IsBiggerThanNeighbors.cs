using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.IsBiggerThanNeighbors
{
    class IsBiggerThanNeighbors
    {
        static void IsBiggerThanTwoNieghbors(int[] array, int position)
        {

            bool isBigger = true;
            
                if (position <= 0 || position >= array.Length-1)
                {
                    isBigger = false;
                    
                }
                else if (array[position] > array[position+1] && array[position] > array[position - 1])
                {
                    isBigger = true;
                }
                    
                else
                    {
                        isBigger = false;
                    }    
            
            Console.WriteLine(isBigger);
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 56, 0, 1, 2 };
            int position = 3;
            IsBiggerThanTwoNieghbors(array, position);
        }

    }
}
