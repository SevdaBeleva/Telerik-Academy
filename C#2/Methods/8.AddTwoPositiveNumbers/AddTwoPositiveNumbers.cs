using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.AddTwoPositiveNumbers
{
    class AddTwoPositiveNumbers
    {
        static List<int> ParseNumberToList ( int number)
        {
            List<int> result = new List<int>();
            do
            {
                result.Add(number % 10);
                number /= 10;
            }
            while (number > 0);
            return result;
            
        }
        static List<int> AddLists(List<int> list, List<int> list2)
        {
        
            List<int> addList = new List<int>();
            int min = Math.Min(list.Count, list2.Count); 
            
            int transfer = 0;
            for (int i = 0; i < min; i++)
            {
                int currentResult = (list[i] + list2[i])+transfer;
                addList.Add(currentResult % 10);
                transfer = currentResult / 10;
            }
            if (transfer > 0)
            {
                addList.Add(transfer);
            }

            int difference = 0; 
            if (min == list.Count)
            {
                difference = list.Count;

               for (int i = difference; i < list2.Count; i++)
                {
                   
                   addList.Add(list2[i]);
                    
               }
            }
            else if (min == list2.Count)
            {
                difference = list2.Count;

                for (int i = difference; i < list.Count; i++)
               {
                      
                   addList.Add(list[i]);  
                }
            }
           
            return addList;
        }
        static List<int> PrintArray(List<int> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            return array;
        }
        static void Main(string[] args)
        { 
            List<int> list1 = ParseNumberToList(12345);
            List<int> list2 = ParseNumberToList(12945);
            PrintArray(AddLists(list1, list2));  
        }
    }
}
