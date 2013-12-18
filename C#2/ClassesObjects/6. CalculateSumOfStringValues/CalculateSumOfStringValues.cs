using System;
using System.Collections.Generic;
namespace _6.CalculateSumOfStringValues
{
    class CalculateSumOfStringValues
    {
         
        static int CalculateSumOfStringArray( string array)
        {
            
            char[] interval = { ' ' }; // point which symbol to be removed, in this case it will be space
            string[] s = array.Split(interval, StringSplitOptions.RemoveEmptyEntries);    // this function will remove all spaces
            List<int> list = new List<int>();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum = sum + int.Parse(s[i]);
            }
            return sum;
           
        }
        static void Main(string[] args)
        {

            string sequence = "43    68    9 23    318";  // here we have more than one space, but the program still works because of the 
                                                           //   StringSplitOptions.RemoveEmptyEntries
            Console.WriteLine(CalculateSumOfStringArray(sequence));
        }
    }
}
