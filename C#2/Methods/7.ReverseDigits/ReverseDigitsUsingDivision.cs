using System;
namespace _7.ReverseDigits
{
    class ReverseDigitsUsingDivision
    {
        static int ReverseDigits(int number)
        {
            int newnumber = 0;             
            do
            {
                newnumber = number % 10;
                Console.Write(newnumber);
                number = number / 10;       
            }
            while (number > 0);
            Console.WriteLine();
            return newnumber;    
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            ReverseDigits(number);
        }
    }
}
