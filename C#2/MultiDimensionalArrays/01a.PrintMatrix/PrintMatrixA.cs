using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01a.PrintMatrix
{
    class PrintMatrixA
    {
        static void Main(string[] args)
        {
             int n = int.Parse(Console.ReadLine());
            int currentValue = 1;
            int[,] array = new int[n, n];
            for (int cols = 0; cols < n; cols++)
            {
                for (int rows = 0; rows < n; rows++)
                {
                    array[rows, cols] = currentValue++;
                }
            }
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(array[rows, cols] + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
