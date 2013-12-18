using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BinaryToHexadecimalDirectly
{
    class DirectlyBase2ToBase16
    {
        static void Main(string[] args)
        {
            string binaryNumber = Console.ReadLine();
            StringBuilder hexNumber = new StringBuilder();

            if (binaryNumber.Length % 4 == 1)
            {
                binaryNumber = "000" + binaryNumber;
            }
            else if (binaryNumber.Length % 4 == 2)
            {
                binaryNumber = "00" + binaryNumber;
            }
            else if (binaryNumber.Length % 4 == 3)
            {
                binaryNumber = "0" + binaryNumber;
            }


            for (int i = 0; i < binaryNumber.Length; i+=4)
            {
                switch (binaryNumber.Substring(i, 4))
                {
                    case "0000": hexNumber.Append("0");
                        break;

                    case "0001": hexNumber.Append("1");
                        break;

                    case "0010": hexNumber.Append("2");
                        break;

                    case "0011": hexNumber.Append("3");
                        break;

                    case "0100": hexNumber.Append("4");
                        break;

                    case "0101": hexNumber.Append("5");
                        break;

                    case "0110": hexNumber.Append("6");
                        break;

                    case "0111": hexNumber.Append("7");
                        break;

                    case "1000": hexNumber.Append("8");
                        break;

                    case "1001": hexNumber.Append("9");
                        break;

                    case "1010": hexNumber.Append("A");
                        break;

                    case "1011": hexNumber.Append("B");
                        break;

                    case "1100": hexNumber.Append("C");
                        break;

                    case "1101": hexNumber.Append("D");
                        break;

                    case "1110": hexNumber.Append("E");
                        break;

                    case "1111": hexNumber.Append("F");
                        break;
                }
                
            }
            Console.Write(hexNumber.ToString());

            Console.WriteLine();
        }
    }
}
