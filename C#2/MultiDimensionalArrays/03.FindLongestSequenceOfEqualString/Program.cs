using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FindLongestSequenceOfEqualString
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string [,] array = new string [rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols ; col++)
                {
                    Console.Write("[{0},{1}] = ", row, col);
                    array[row, col] = Console.ReadLine();
                }
                Console.WriteLine();
            }





            






















            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0, 3} | ", array[ row, col]);
                    
                }
                Console.WriteLine();
            }


        }
    }
}
