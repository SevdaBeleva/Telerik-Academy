using System;
namespace _4.SortArrayFindBiggestNumber
{
    class SortArrayFindBiggestNUmber
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[k];
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(array[i]);
            }
            int searchedElement = Array.BinarySearch(array, k);
            
            if (searchedElement < -1)
            {
                Console.WriteLine("The number bigger or equal to {0} is {1}", k, array [~searchedElement-1]);
            }
            else if (~searchedElement == 0)
            {
                Console.WriteLine("This element doesn't excist");
            }
            else
            {
                Console.WriteLine("The largest number in the array which is bigger or equal to {0} is {1} ", k, array[searchedElement]);
            }
            
           
            
 
        }
    }
}
