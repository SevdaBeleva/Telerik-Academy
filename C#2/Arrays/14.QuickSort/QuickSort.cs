using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            {

                int[] arr = { 91, 984, 466, 817, 730, 377, 232, 897, 488, 731 };
                SortQuickly(arr, 0, arr.Length - 1);
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }
        }
           
       static int Partition(int[] arr, int start, int stop)
         {
               int left = start;
               int right = stop;
               int pivot = arr[start];
               int currentElement = right;
               while (left != right)
               {
                   if (pivot <= arr[currentElement] && currentElement == right)
                   {
                      right--;
                      currentElement = right;
                   }
                  else if (pivot > arr[currentElement] && currentElement == right)
                  {
                      arr[left] = arr[currentElement];
                      arr[currentElement] = pivot;
                      left++;
                      currentElement = left;
                  }

                  else if (pivot <= arr[currentElement] && currentElement == left)
                  {
                       arr[right] = arr[currentElement];
                       arr[currentElement] = pivot;
                       right--;
                       currentElement = right;
                  }

                  else
                   {
                       left++;
                       currentElement = left;
                   }
              }
              return currentElement;
           }
          static void SortQuickly(int[] arr, int p, int r)
           {
               if (p < r)
               {
                   int q = Partition(arr, p, r);
                   SortQuickly(arr, p, q - 1);
                   SortQuickly(arr, q + 1, r);
               }
        }
    }
}
