using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;


// task 2 Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
//sum, product, min, max, average.

namespace Extensions
{
   public static class IEnumerableExtensionMethods
    {
       public static int GetSum (this IEnumerable<int> elements)
       {
          int result =  elements.Sum();
          return result;
       }

       public static double GetAverage(this IEnumerable<int> elements)
       {
           double result = elements.Average();
           return result;
       }

       public static int GetMin(this IEnumerable<int> elements)
       {
           int result = elements.Min();
           return result;
       }

       public static int GetMax(this IEnumerable<int> elements)
       {
           int result = elements.Max();
           return result;
       }

       
    }
}
