using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _11.BinarySearch
{
    class BinarySearch
    {
        public static void BinarySearch1 (int[] array, int number, int minIndex, int maxIndex)
        {
            int middle = (minIndex + maxIndex)/ 2;
           
            if (number > array[middle])
            {
                minIndex = middle + 1;
            }
            else if (number < array[middle])
            {
                maxIndex = middle - 1;
            }
            else if (number == array[middle])
            {
                Console.WriteLine(middle);
                return;
            }
            
            BinarySearch1(array, number, minIndex, maxIndex);

 
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int number = int.Parse(Console.ReadLine());
                Array.Sort(array);
            BinarySearch1(array, number, 0, array.Length);
            
        }
    }
}
