using System;
namespace _13.SolveTasks
{
    class SolveTasks
    {
        static int ReverseDigits(int number)  
        {
            int newNumber = 0;
            do
            {
                newNumber = number % 10;
                Console.Write( newNumber );
                number = number / 10;
            }
            while (number > 0);
            Console.WriteLine();
            return newNumber;         
        }

        static void InputArray(decimal[] array, decimal n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = decimal.Parse(Console.ReadLine());
            }

        }

        static decimal GetAverageSum(decimal[] array, decimal n)
        {
            
            InputArray(array, n);
            decimal sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i] ;
                
            }
            Console.WriteLine("the average sum is: " + sum / array.Length);
            return sum;
        }
        static double SolveLinearEquation(double  a, double b)
        {
            double x = -b / a;
            Console.WriteLine("x = " + x);
            return x;
        }
        static void InputReverseDigits()
        {
            Console.WriteLine("Enter a number you want to reverse: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("The number must be bigger than 0 ");   
            }
            else
            { 
               ReverseDigits(number);  
            }
        }
        
        static void InputGetAverageSum()
        {
            Console.WriteLine("Enter the length of the array");
            int length = int.Parse(Console.ReadLine());
            decimal[] array = new decimal[length];
            if (array.Length < 0)
            {
                Console.WriteLine("You must enter numbers in the array!!!");
            }
            else
            {
                GetAverageSum(array, length);
            }
        }
        static void InputLinearEquation()
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            
            if (a <= 0)
            {
                Console.WriteLine("a should be not equal to 0 or negative");
            }
            else 
            {
                Console.Write("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                SolveLinearEquation(a, b);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to choose a task: " + "\n" +
                "1 - Reverse Digits of number" + "\n" +
                "2 - Get the average sum of sequence" + "\n"+
                "3 - Solve Linear Equation");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("You chose to Reverse Digits"); 
                InputReverseDigits();
            }
            else if (choice == 2)
            {
                Console.WriteLine("You chose to Get Average sum of sequence" ); 
                InputGetAverageSum();
            }
            else if (choice == 3)
            {
                Console.WriteLine("You chose to solve Linear equation"); 
                InputLinearEquation();
            }
            
        }
    }
}
