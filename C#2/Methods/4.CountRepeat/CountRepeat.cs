using System;

namespace _4.CountRepeat
{
    class CountRepeat
    {
        static int CountRepeat1(int[] array, int number)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (number == array[i])
                {
                    count++;
                }       
            }
            Console.WriteLine("The number {0} appears {1} times", number, count);  
            return count;
            
        }
        static void Main(string[] args)
        {
            int [] array = new int[5];
            int number = 3;
            CountRepeat1(array, number);
        }
    }
}
