using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Carpets
    {
        static string ReverseString(string x)
        {
            char[] arr = x.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main()
        {
            //get height and width of the shape
            byte size = byte.Parse(Console.ReadLine());

            //top to middle
            string left = "/";
            for (int row = 1; row <= size / 2; row++)
            {
                Console.Write(new string('.', size / 2 - row));
                Console.Write(left);
                Console.Write(ReverseString(left).Replace('/', '\\'));
                Console.WriteLine(new string('.', size / 2 - row));
                if (row % 2 != 0) left = left + " ";
                if (row % 2 == 0) left = left + "/";
            }

            //middle to bottom
            left = left.Replace('/', '\\');
            for (int row = size / 2; row >= 1; row--)
            {
                if (row % 2 != 0) left = left.TrimEnd(' ');
                if (row % 2 == 0) left = left.TrimEnd('\\');
                Console.Write(new string('.', size / 2 - row));
                Console.Write(left);
                Console.Write(ReverseString(left).Replace('\\', '/'));
                Console.WriteLine(new string('.', size / 2 - row));
            }
        }
    }
}