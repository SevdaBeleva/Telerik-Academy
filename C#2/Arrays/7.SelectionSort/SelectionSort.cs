using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 51, 1, 38, 6, 7, 12, 9, 15, 78, 7 };
            int min = 0;
            int temp = 0;
            for(int i =0; i<array.Length; i++)
            {
                
                min = i;
                for (int j = i + 1; j < array.Length; j++ )
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;

                Console.WriteLine(array[i]);   
              
            }
            
            
        }
    }
}
