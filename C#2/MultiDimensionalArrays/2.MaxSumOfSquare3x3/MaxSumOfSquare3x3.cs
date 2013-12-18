using System;
namespace _2.MaxSumOfSquare3x3
{
    class MaxSumOfSquare3x3
    {
        static void Main(string[] args)
        {
           
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, cols];

            // Read the matrix
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {

                    Console.Write("matrix[{0},{1}] = ", row, col);
                   array[row, col] = int.Parse(Console.ReadLine());
                }
            }

            // Print the matrix
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write( "{0}, ",array[row, col]);
                }
                Console.WriteLine();
            }

            int sum = int.MinValue;
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            // Find the best paltform and its sum
            for (int row = 0; row <= array.GetLength(0) -3; row++)
            {
                for (int col = 0; col <= array.GetLength(1) -3; col++)
                {
                       sum = array[row, col] + array[row, col + 1] + array[row, col + 2] +
                       array[row + 1, col] + array[row + 1, col + 1] + array[row + 1, col + 2] +
                       array[row + 2, col] + array[row + 2, col + 1] + array[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                   
                }
            }
            Console.WriteLine("the best platform is: ");
            Console.WriteLine("{0}, {1}, {2}", 
                array[bestRow, bestCol],
                array[bestRow, bestCol+1], 
                array[bestRow, bestCol+2]);
            Console.WriteLine("{0}, {1}, {2}",
                array[bestRow+1, bestCol],
                array[bestRow+1, bestCol+1],
                array[bestRow+1, bestCol + 2]);
            Console.WriteLine("{0}, {1}, {2}",
                array[bestRow + 2, bestCol],
                array[bestRow + 2, bestCol + 1],
                array[bestRow + 2, bestCol + 2]);

            Console.WriteLine("\n" + "the best sum is {0}", bestSum);
        }

    }
}
