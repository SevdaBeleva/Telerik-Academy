using System;
namespace _7aReverseNumbersUsingDivision
{
    class ReverseNumbersUsingString
    {
        static char [] ReverseDigits(string number)
        {
            number = number.TrimEnd('0');
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(array);
            return array;

        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReverseDigits(number);   
        }
    }
}
