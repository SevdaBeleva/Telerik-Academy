using System;
namespace _2.ConvertBinaryToDecimal
{
    class Base2ToBase10
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int decimalNumber = 0;

            for (int i = 0; i < number.Length; i++)
            {
                decimalNumber = decimalNumber + int.Parse(number[i].ToString())*(int)(Math.Pow(2, number.Length -(i+1)));
            }
            Console.WriteLine(decimalNumber);
        }
    }
}
