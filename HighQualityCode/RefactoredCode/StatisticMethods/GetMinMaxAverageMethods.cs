using System;

namespace StatisticMethods
{
   public class GetMinMaxAverageMethods
    {
       public static double GetMaxNumber(double[] array)
       {
           double maxNumber = 0;
           for (int i = 0; i < array.Length; i++)
           {
               maxNumber = array[0];
               if (array[i] > maxNumber)
               {
                   maxNumber = array[i];
               }
           }
           return maxNumber;
       }

       public static double GetMinNumber(double[] array)
       {
           double minNumber = double.MaxValue;
           for (int i = 0; i < array.Length; i++)
           {
               if (array[i] < minNumber)
               {
                   minNumber = array[i];
               }
           }
           return minNumber;
       }

       public static double GetAverageValue(double[] array)
       {
           double sum = 0;
           for (int i = 0; i < array.Length; i++)
           {
               sum += array[i];
           }
           return sum/array.Length;
       }

       static void Main(string[] args)
       {
           // Test methods 
           double[] array = {12, 45, 23, 6, 78};
           Console.WriteLine(GetAverageValue(array));
           Console.WriteLine(GetMinNumber(array));
           Console.WriteLine(GetMaxNumber(array));
           
        }
    }
}
