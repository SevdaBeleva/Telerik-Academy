using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopRefactoring
{
    public class TestRefactoredLoop
    {
        static void Main(string[] args)
        {
            int[] array = {12, 46, 1, 2, 45, 7, 45, 12, 45};
            int expectedValue = 12;

            CheckNumber(array, expectedValue);

        }

        public static void CheckNumber(int [] array, int expectedValue)
        {
            for (int i = 0; i < array.Length; i++ )
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found!");
                        break;
                    }     
                }
                else
                {
                    // Nothing happens
                }
            }
        }
    }
}
