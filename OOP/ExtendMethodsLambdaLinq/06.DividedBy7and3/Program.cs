using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DividedBy7and3
{
    class Program
    {
        public static void DividedBy7and3Lambda(int[] array)  // task 6: Write a program that prints from 
                                                             //given array of integers all numbers that are divisible by 7 and 3
                                                             // Using lambda expressions
        {
            var wantedNumbers = array.Where(x => x % 21 == 0);

            foreach (var numbers in wantedNumbers)
            {
                Console.WriteLine(numbers);
            }
        }

        public static void DividedBy7and3Linq(int[] array)    // task 6: Write a program that prints from 
                                                             //given array of integers all numbers that are divisible by 7 and 3
                                                                // Using LINQ   
        {
            var wantedNumbers = from numbers in array
                                where numbers % 21 == 0
                                select numbers;
            foreach (var numbers in wantedNumbers)
            {
                Console.WriteLine(numbers);
            }
 
        }
        static void Main(string[] args)
        {
            int[] array = new int[55];
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = i;
            }

            DividedBy7and3Lambda(array); // check the result with lambda expression
            DividedBy7and3Linq(array);   // check the result with linq

        }
    }
}
