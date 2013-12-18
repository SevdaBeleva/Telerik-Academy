using System;
namespace _2.GetMax
{
    class GetMax
    {
        static int GetMaxNumber(int firstNumber, int secondNumber)
        {
            int maxNumber = firstNumber;
            if( secondNumber > firstNumber)
            {
                maxNumber = secondNumber;
            }
            return maxNumber;
        }
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = GetMaxNumber(firstNumber, secondNumber);
            Console.WriteLine(GetMaxNumber(thirdNumber, result));
        }
    }
}
