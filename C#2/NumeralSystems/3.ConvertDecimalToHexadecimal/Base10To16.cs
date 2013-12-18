using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ConvertDecimalToHexadecimal
{
    class Base10To16
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            StringBuilder hexDigit = new StringBuilder();
            string hexNumber = null;
            while (number > 0)
            {
                switch (number % 16)
                {
                    case 10: hexDigit.Append('A');
                        break;

                    case 11: hexDigit.Append('B');
                        break;

                    case 12: hexDigit.Append('C');
                        break;

                    case 13: hexDigit.Append('D');
                        break;

                    case 14: hexDigit.Append('E');
                        break;

                    case 15: hexDigit.Append('F');
                        break;
                    default: hexDigit.Append(number % 16);
                        break;
                }
                number = number / 16;
                hexNumber = hexDigit.ToString();
            }

            for (int i = hexNumber.Length-1; i > -1; i--)
            {
                Console.Write(hexNumber[i]);
            }
            Console.WriteLine();
        }
    }
}
