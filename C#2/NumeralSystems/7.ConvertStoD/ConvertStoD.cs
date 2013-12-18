using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ConvertStoD
{
    class ConvertStoD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FROM base: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("TO base: ");
            int d = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the number you want to convert:");
            string number = Console.ReadLine();

            // Convert to decimal numeral system
            int decimalNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > '9')
                {
                    decimalNumber = (decimalNumber + number[i] - '7') * (int)(Math.Pow(s, number.Length - 1 -i));
                }
                else
                {
                    decimalNumber = decimalNumber + int.Parse(number[i].ToString()) * (int)(Math.Pow(s, number.Length - (i + 1)));
                }
            }
            Console.WriteLine(decimalNumber);

            // Convert FROM decimal to D numeral system using StringBuilder
            StringBuilder wantedNumber = new StringBuilder();
            while (decimalNumber > 0)
            {
                int result = decimalNumber >= d ? (decimalNumber % d) : decimalNumber;
                switch (result)
                {
                    case 0: wantedNumber.Append('0');
                        break;

                    case 1: wantedNumber.Append('1');
                        break;

                    case 2: wantedNumber.Append('2');
                        break;

                    case 3: wantedNumber.Append('3');
                        break;

                    case 4: wantedNumber.Append('4');
                        break;

                    case 5: wantedNumber.Append('5');
                        break;

                    case 6: wantedNumber.Append('6');
                        break;

                    case 7: wantedNumber.Append('7');
                        break;

                    case 8: wantedNumber.Append('8');
                        break;

                    case 9: wantedNumber.Append('9');
                        break;

                    case 11: wantedNumber.Append('B');
                        break;

                    case 12: wantedNumber.Append('C');
                        break;

                    case 13: wantedNumber.Append('D');
                        break;

                    case 14: wantedNumber.Append('E');
                        break;

                    case 15: wantedNumber.Append('F');
                        break;
                    
                }
                decimalNumber = decimalNumber / d;
            }
            // reverse string
            StringBuilder reversed = new StringBuilder();
            for (int i = wantedNumber.Length - 1; i > -1; i--)
            {
                reversed.Append(wantedNumber[i]);
            }
            // print reversed string and get the number you want
            Console.WriteLine(reversed.ToString());

            Console.WriteLine();

        }
    }
}
