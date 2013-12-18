using System;
namespace _01c.PrintMatrix
{
    class PrintMatrixC
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int [n,n];
            int currentValue = 1;
            int x = n-1; 
            int y = 0;

            int maxLength = (n * n).ToString().Length;
            int currentLength;
           
                    for (currentValue = 1; currentValue <= n * n; currentValue++)
                    {
                        array[x++, y++] = currentValue;

                        if (x == n || y == n)
                        {
                             x--;

                            if (y == n)
                            {
                                x--;
                                y--;
                            }
                            while (x - 1 >= 0 && y - 1 >= 0)
                            {
                                x--;
                                y--;
                            }
                        }
                    }
                    for (int rows = 0; rows <= n - 1; rows++)
                    {
                        for (int cols = 0; cols <= n - 1; cols++)
                        {
                            currentLength = array[rows, cols].ToString().Length;
                            Console.Write("{0}", array[rows, cols] + "  ");
                        }
                        Console.WriteLine();

                    }
        }
    }
}
