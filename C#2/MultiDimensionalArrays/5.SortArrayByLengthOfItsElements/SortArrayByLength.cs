using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _5.SortArrayByLengthOfItsElements
{
    class SortArrayByLength
    {
        static IEnumerable<string> SortByLength (IEnumerable <string> elements)
        { 
            var sorted = from e in elements orderby e.Length ascending 
                            select e;

            return sorted;
        }
        static void Main(string[] args)
        {
            string[] array = {"this ", "is ", "a ", "very ", "big " , "cat "};
            foreach (string e in SortByLength(array))
            {
                Console.WriteLine(e);
            }
        }
    }
}