using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SevenLandNumbers
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int lastDigit = input % 10;

        if (lastDigit == 6)
        {
            Console.WriteLine(input + 4);
        }
        else
        {
            Console.WriteLine(input + 1);
        }
    }
}

