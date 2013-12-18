using System;
using System.Numerics;
namespace _10.Factorial1to100
{
    class Factorial1to100
    {
        static BigInteger Factorial(int number)
        {
            if (number <= 1)
                return 1;
            else return number*Factorial(number-1);      
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of number {0} is: {1} ", number, Factorial(number));      
        }
    }
}
