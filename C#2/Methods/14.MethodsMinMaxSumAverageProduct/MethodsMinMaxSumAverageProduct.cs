using System;

namespace _14.MethodsMinMaxSumAverageProduct
{
    class MethodsMinMaxSumAverageProduct
    {
       
        static int GetMaxValue(  int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
            return max;
        }
        static int GetMinValue(int[] array)
        {
            int smallest = array[0]; 
            for (int i = 0; i < array.Length; i++)
            {    
                if (array[i] < smallest)
                {
                    smallest = array[i];
                }    
            }
            Console.WriteLine(smallest);
            return smallest;
        }

        static decimal GetAverageSum(int[] array)
        {
            decimal averageSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                averageSum += array[i]; 
            }
            averageSum = averageSum / array.Length;
            Console.WriteLine(averageSum);
            return averageSum;
        }
        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
            return sum;
        }
        static int GetProduct(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product = product * array[i];
            }
            Console.WriteLine(product);
            return product;
        }
        static void Main(string[] args)
        {   
            int[] array = { 18, 23, 5, 6, 89, 12 };
            GetMinValue(array);
            GetMaxValue (array);
            GetAverageSum(array);
            GetSum(array);
            GetProduct(array);
        }
    }
}
