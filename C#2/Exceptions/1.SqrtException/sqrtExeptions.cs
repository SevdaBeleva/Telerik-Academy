using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SqrtException
{
    class sqrtExeptions
    {
      
        static void Main(string[] args)
        {
               
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException();
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(number));
                }
            }

            catch (OverflowException overflEx)
            {
                Console.Error.WriteLine("Invalid number");
                Console.WriteLine(overflEx.Message);

            }

            catch (FormatException formatEx)
            {
                Console.WriteLine("Invalid number");
                Console.WriteLine(formatEx.Message);
            }

            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
