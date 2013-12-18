using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IsLeapYear
{
    class IsleapYear
    {
        static void Main(string[] args)
        {


            if (DateTime.IsLeapYear(int.Parse(Console.ReadLine())) == true)
            {
                Console.WriteLine("This year is Leap");
            }
            else 
            {
                Console.WriteLine("This year is NOT Leap");
            }
            
            
        }
    }
}

