using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteen
{
    public class PlayBoard
    {

        /*==========================================*/
        /*          PlayBoard Fields
        /*==========================================*/

        private int[,] gameBoard;
        private int rows;
        private int cols;
        private int moveCount;

        /*==========================================*/
        /*          PlayBoard Constructor
        /*==========================================*/

        public PlayBoard()
        {
            this.gameBoard = new int[4, 4]
            { 
                { 1,  2,  3,  4  }, 
                { 5,  6,  7,  8  }, 
                { 9,  10, 11, 12 }, 
                { 13, 14, 15, 0  } 
            };

            this.Rows = 3;
            this.Cols = 3;
            this.MoveCount = 0;
        }

        /*==========================================*/
        /*         PlayBoard Properties
        /*==========================================*/

        public int[,] GameBoard
        {
            get
            { 
                return gameBoard;
            }
            private set 
            { 
                gameBoard = value; 
            }
        }

        public int Rows
        {
            get 
            {
                return rows;
            }
            private set 
            { 
                rows = value; 
            }
        }

        public int Cols
        {
            get 
            { 
                return cols;
            }
            private set
            { 
                cols = value; 
            }
        }

        public int MoveCount
        {
            get 
            { 
                return moveCount;
            }
            set 
            { 
                moveCount = value;
            }
        }

        /// <summary>
        /// Board representation indexator
        /// </summary>
        /// <param name="row">Indexator row parameter for PlayBoard property</param>
        /// <param name="col">Indexator col parameter for PlayBoard property</param>
        /// <returns></returns>
        public int this[int row, int col]
        {
            get
            {
                return gameBoard[row, col];
            }
            private set
            {
                gameBoard[row, col] = value;

            }
        }

        /*==========================================*/
        /*          PlayBoard Methods
        /*==========================================*/

        /// <summary>
        /// Check if user move is valid in the GameBoard
        /// 1. Is the Move is out of board range
        /// 2. Is the Move valid
        /// </summary>
        /// <param name="row">GameBoard row</param>
        /// <param name="col">GameBoard column</param>
        /// <returns></returns>
        public bool IsValidMove(int row, int col)
        {
            if ((row == Rows - 1 || row == Rows + 1) && col == Cols)
            {
                return true;
            }

            if ((row == Rows) && (col == Cols - 1 || col == Cols + 1))
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// This method generates random starting board by shifting rows and cols elements
        /// The method uses random generator and different step cases for proper row and col generation
        /// </summary>
        public void PlayBoardGenerator()
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int emptyCell = random.Next(3);

                if (emptyCell == 0)
                {
                    ShuffleBoardNumbers(ref emptyCell, (Rows - 1), Cols);
                }

                if (emptyCell == 1)
                {
                    ShuffleBoardNumbers(ref emptyCell, Rows, (Cols + 1));
                }

                if (emptyCell == 2)
                {
                    ShuffleBoardNumbers(ref emptyCell, (Rows + 1), Cols);
                }

                if (emptyCell == 3)
                {
                    ShuffleBoardNumbers(ref emptyCell, Rows, (Cols - 1));
                }
            }
        }

        /// <summary>
        ///  Get GameBoard cell and shuffle it through the rows and cols in the base 
        ///  GameBoard matrix could be replaced with Shuffle method 
        /// </summary>
        /// <param name="emptyCell">Reference to emptyCell random start position cursor</param>
        /// <param name="currentRow">Current GameBoard row for shuffling</param>
        /// <param name="currentCol">Current GameBoard col for shuffling</param>
        public void ShuffleBoardNumbers(ref int emptyCell, int currentRow, int currentCol)
        {
            if ((currentRow >= 0 && currentRow <= 3) && (currentCol >= 0 && currentCol <= 3))
            {
                int temp = GameBoard[Rows, Cols];

                GameBoard[Rows, Cols] = GameBoard[currentRow, currentCol];
                GameBoard[currentRow, currentCol] = temp;

                Rows = currentRow;
                Cols = currentCol;
            }
            else
            {
                emptyCell++;
            }
        }


        /// <summary>
        /// Check if at some moment the user goes out of GameBoard range
        /// </summary>
        /// <returns></returns>
        public bool IsMoveInBoardRange()
        {
            if (GameBoard[Rows, Cols] == 0)
            {
                int cells = 1;
                for (int i = 0; i < GameBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < GameBoard.GetLength(1); j++)
                    {
                        if (cells <= 15)
                        {
                            if (GameBoard[i, j] == cells)
                            {
                                cells++;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }


        /// <summary>
        /// Get user input number and check if:
        /// 1. Input is valid
        /// 2. Assign GameBoard layout change
        /// 3. Return boolean result for changing control flow
        /// </summary>
        /// <param name="number">user input</param>
        /// <returns></returns>
        public bool MoveNumber(int number)
        {
            int boardRow = BoardTraversRow(number);
            int boardCol = BoardTraversCol(number);

            if (IsValidMove(boardRow, boardCol))
            {
                ChangePlayBoardLayout(boardRow, boardCol);

                MoveCount++;

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Rearange GameBoard layout after valid User move
        /// </summary>
        /// <param name="boardRow"></param>
        /// <param name="boardCol"></param>
        private void ChangePlayBoardLayout(int boardRow, int boardCol)
        {
            int temp = GameBoard[boardRow, boardCol];
            GameBoard[boardRow, boardCol] = GameBoard[Rows, Cols];
            GameBoard[Rows, Cols] = temp;
            Rows = boardRow;
            Cols = boardCol;
        }

        /// <summary>
        ///  Travers PlayBoard and return the current row for move execution
        /// </summary>
        /// <param name="number">number of user input</param>
        /// <returns></returns>
        public int BoardTraversRow(int number)
        {
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    if (GameBoard[i, j] == number)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        /// <summary>
        ///  Traverse the PlayBoard and return the current col for move execution
        /// </summary>
        /// <param name="number">number of user input</param>
        /// <returns></returns>
        public int BoardTraversCol(int number)
        {
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    if (GameBoard[i, j] == number)
                    {
                        return j;
                    }
                }
            }
            return 0;
        }

        /// <summary>
        ///  Print of GameBoard string implementation
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder boardBuilder = new StringBuilder();

            boardBuilder.AppendLine("------------------");

            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                boardBuilder.Append("|");

                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    if (GameBoard[i, j] == 0)
                    {
                        boardBuilder.AppendFormat(" {0,-3}", "X");
                    }
                    else
                    {
                        boardBuilder.AppendFormat(" {0,-3}", GameBoard[i, j]);
                    }
                }

                boardBuilder.AppendLine("|");
            }
            boardBuilder.AppendLine("------------------");

            return boardBuilder.ToString();
        }
    }
}
