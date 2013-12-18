using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ConvertHexaDecimalToDecimal
{
    class Base16To10
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            //number.ToCharArray();
            //number.ToUpper();
            int decimalNumber = 0;
            int hexNumber = 0;

            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case 'A': hexNumber = 10;
                        break;
                    case 'a': hexNumber = 10;
                        break;

                    case 'B': hexNumber = 11;
                        break;

                    case 'C': hexNumber = 12;
                        break;

                    case 'D': hexNumber = 13;
                        break;

                    case 'E': hexNumber = 14;
                        break;

                    case 'F': hexNumber = 15;
                        break;

                    default: hexNumber = int.Parse(Convert.ToString(number[i]));
                        break;
                }

                decimalNumber = decimalNumber + hexNumber * (int) (Math.Pow(16, number.Length - ( i + 1)));
            }
            Console.WriteLine(decimalNumber);

        }
    }
}
