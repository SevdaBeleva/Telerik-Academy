using System;
namespace _01b.PrintMatrix
{
    class PrintMatrixB
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int currentValue = 1;
            for (int cols = 0; cols < n; cols++)
            {
                if (cols % 2 == 0)
                {
                    for (int rows = 0; rows < n; rows++)
                    {
                        array[rows, cols] = currentValue++;
                    }
                }
                else
                {
                    for (int rows = n - 1; rows >= 0; rows--)
                    {
                        array[rows, cols] = currentValue++;
                    }
                }
                
            }

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(array[rows, cols] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
