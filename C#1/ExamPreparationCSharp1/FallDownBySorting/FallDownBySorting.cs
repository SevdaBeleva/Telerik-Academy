using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FallDownBySorting
{
    static void Main(string[] args)
    {
        int[,] board = new int[8, 8];

        for (int row = 0; row < 8; row++)
        {
            int number = int.Parse(Console.ReadLine());
            string numberToString = Convert.ToString(number, 2).PadLeft(8, '0');

            for (int col = 0; col < 8; col++)
            {
                board[row, col] = int.Parse(numberToString[col].ToString());
            }
        }

        for (int col = 0; col < 8; col++)
        {
            int [] secondMatrix = new int [8];
            for (int row = 0; row < 8; row++)
            {
                if (board[row, col] == 1)
                {
                    secondMatrix[row] = 1;
                }
            }

            Array.Sort(secondMatrix);

            for (int i = 0; i < 8; i++)
            {
                board[7 - i, col] = secondMatrix[7-i];
            }
        }

        for (int row = 0; row < 8; row++)
        {
            StringBuilder builder = new StringBuilder();
            for (int col = 0; col < 8; col++)
            {
                builder.Append(board[row, col]);
            }

            int result = Convert.ToInt32(builder.ToString(), 2);
            Console.WriteLine(result);
        }

    }
}
