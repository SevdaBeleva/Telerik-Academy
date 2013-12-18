using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Formula1Bit
{
    static void Main(string[] args)
    {
       bool[,] board = new bool[8, 8];

        for (int i = 0; i < 8; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
           {  
                board[i, j] = ((currentNumber >> j) & 1 ) != 0;
            }
        }

        int currentRow = 0;
        int currentCol = 0;
        bool exitFound = false;
        int stepCounter = 0;
        int directionCounter = 0;
        string lastDirection = "down";
        string direction = "down";

        while (true)
        {
            if (board[currentRow, currentCol])
            {
                break;
            }

            stepCounter++;

            if (currentRow == 7 && currentCol == 7)
            {
                exitFound = true;
                break;
            }

            if (lastDirection == "down" && (currentRow + 1 > 7 || board[currentRow + 1, currentCol]))
            {
                lastDirection = "left";
                direction = "down";
                if(currentCol + 1 > 7 || board[currentRow, currentCol+1])
                {
                    break;
                }
                directionCounter++;
            }

            else if (lastDirection == "left" && direction == "down" && (currentCol + 1 > 7 || board[currentRow, currentCol +1 ]))
            {
                lastDirection = "up";
                if (currentRow - 1 < 0 || board[currentRow -1, currentCol])
                {
                    break;
                }
                directionCounter++;
            }
            else if (lastDirection == "left" && direction == "up" && (currentCol + 1 > 7 || board[currentRow, currentCol + 1]))
            {
                lastDirection = "down";
                if (currentRow + 1 > 7 || board[currentRow + 1, currentCol])
                {
                    break;
                }
                directionCounter++;
            }
            else if (lastDirection == "up" && (currentRow - 1 < 0 || board[currentRow - 1, currentCol]))
            {
                lastDirection = "left";
                direction = "up";
                if (currentCol + 1 > 7 || board[currentRow, currentCol + 1])
                {
                    break;
                }
                directionCounter++;
            }


            if (lastDirection == "down")
            {
                currentRow++;           
            }
            else if (lastDirection == "left")
            {
                currentCol++;
            }
            else if (lastDirection == "up")
            {
                currentRow--;
            }
        }



        if (exitFound)
        {
            Console.WriteLine(stepCounter + " " + directionCounter);
        }
        else
        {
            Console.WriteLine("No" + " " + stepCounter);
        }
    }
}

