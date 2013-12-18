using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire
{
    class Fire
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int half = number / 2;
            char dots = '.';
            char leftT = '\\';
            char rightT = '/';
            char torch = '#';
            char dash = '-';

            for (int i = 0; i < half; i++)
            {
                Console.Write(new string (dots, half - 2 - (i-1)));
                Console.Write(new string(torch, 1));
                Console.Write(new string(dots, i * 2));
                Console.Write(new string(torch, 1));
                Console.WriteLine(new string(dots, half -2- (i - 1)));
            }

            for (int i = 0; i < number/4; i++)
            {
                Console.Write(new string (dots, i));
                Console.Write(new string(torch, 1));
                Console.Write(new string(dots, number - (i * 2) - 2));
                Console.Write(new string(torch, 1));
                Console.WriteLine(new string(dots, i));
            }

            Console.WriteLine(new string (dash, number));

            for (int i = 0; i < half; i++)
            {
                Console.Write(new string (dots, i));
                Console.Write(new string (leftT, half - i));
                Console.Write(new string(rightT, half - i));
                Console.WriteLine(new string(dots, i));
            }

        }
    }
}
