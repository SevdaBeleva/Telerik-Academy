using System;
namespace _15.GenericMethods
{
    class GenericMethods
    {
        static T GetMinValue<T>( T [] array)
        {
            dynamic smallest = array[0];
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

        static T GetMaxValue<T>( T [] array)
        {
            dynamic max = array[0];
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

        static T GetAverageSum<T>( T [] array)
        {
            dynamic averageSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                averageSum += array[i];
            }
            averageSum = averageSum / array.Length;
            Console.WriteLine(averageSum);
            return averageSum;
        }

        static T GetSum<T>( T [] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
            return sum;
        }

        static T GetProduct<T>( T [] array)
        {
            dynamic product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product = product * array[i];
            }
            Console.WriteLine(product);
            return product;
        }

        static void Main(string[] args)
        {
            int [] array = { 1,2,3,4,5,6,7,8,8};
            GetMinValue(array);
            GetMaxValue(array);
            GetAverageSum(array);
            GetSum(array);
            GetProduct(array);
        }
    }
}
