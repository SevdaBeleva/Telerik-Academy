using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReadNumberException
{
    class ReadNumberExceptions
    {
        static void InputNumberException(int start, int end)
        {
            
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();    
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number must be BIGGER than start number and SMALLER than end number");
            }

            catch (FormatException)
            {
                Console.WriteLine("The number must be of Int type");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a strart number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter an end number: ");
            int end = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++ )
            {  
               InputNumberException(start, end); 
            }
        }
    }
}
