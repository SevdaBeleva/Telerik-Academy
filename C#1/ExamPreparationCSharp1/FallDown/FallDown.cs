using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FallDown
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
            int counter = 0;
            for (int row = 0; row < 8; row++)
            {
                if (board[row, col] == 1)
                {
                    counter++;
                    board[row, col] = 0;
                }
            }

            for (int i = 0; i < counter; i++)
            {
                board[7 - i, col] = 1;
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
