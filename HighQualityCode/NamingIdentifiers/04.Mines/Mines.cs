using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Mines
    {
        public class Score
        {
            private string name;
            private int scores;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Scores
            {
                get { return scores; }
                set { scores = value; }
            }

            public Score() { }

            public Score(string name, int scores)
            {
                Name = name;
                Scores = scores;
            }
        }

        static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] board = CreateBoard();
            char[,] mines = LoadMines();
            int counter = 0;
            bool explosion = false;
            List<Score> champions = new List<Score>(6);
            int row = 0;
            int column = 0;
            bool start = true;
            const int maks = 35;
            bool reachMaxScore = false;

            do
            {
                if (start)
                {
                    Console.WriteLine("You are going to play Minesweeper”. Try to find squares without mines." +
                    "Command 'top': ranking, 'restart': new game, 'exit': leave game!");
                    PrintBoard(board);
                    start = false;
                }
                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column) &&
                        row <= board.GetLength(0) && column <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        CreateRanking(champions);
                        break;
                    case "restart":
                        board = CreateBoard();
                        mines = LoadMines();
                        PrintBoard(board);
                        explosion = false;
                        start = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                Play(board, mines, row, column);
                                counter++;
                            }
                            if (maks == counter)
                            {
                                reachMaxScore = true;
                            }
                            else
                            {
                                PrintBoard(board);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }
                if (explosion)
                {
                    PrintBoard(mines);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", counter);
                    string nickName = Console.ReadLine();
                    Score score = new Score(nickName, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Scores < score.Scores)
                            {
                                champions.Insert(i, score);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Score r1, Score r2) => r2.Scores.CompareTo(r1.Scores));
                    CreateRanking(champions);
                    board = CreateBoard();
                    mines = LoadMines();
                    counter = 0;
                    explosion = false;
                    start = true;
                }
                if (reachMaxScore)
                {
                    Console.WriteLine("\nBRAVOOOS! You open all cells!");
                    PrintBoard(mines);
                    Console.WriteLine("Enter your name: ");
                    string imeee = Console.ReadLine();
                    Score result = new Score(imeee, counter);
                    champions.Add(result);
                    CreateRanking(champions);
                    board = CreateBoard();
                    mines = LoadMines();
                    counter = 0;
                    reachMaxScore = false;
                    start = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void CreateRanking(List<Score> score)
        {
            Console.WriteLine("\nscore:");
            if (score.Count > 0)
            {
                for (int i = 0; i < score.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, score[i].Name, score[i].Scores);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Ranking!\n");
            }
        }

        private static void Play(char[,] board, char[,] mines, int row, int column)
        {
            char kolkoBombi = CountMinesIn(board, row, column);
            mines[row, column] = kolkoBombi;
            board[row, column] = kolkoBombi;
        }

        private static void PrintBoard(char[,] board)
        {
            int row = board.GetLength(0);
            int column = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < column; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] LoadMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] playGround = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playGround[i, j] = '-';
                }
            }

            List<int> listOfMines = new List<int>();
            while (listOfMines.Count < 15)
            {
                Random random = new Random();
                int mine = random.Next(50);
                if (!listOfMines.Contains(mine))
                {
                    listOfMines.Add(mine);
                }
            }

            foreach (int mine in listOfMines)
            {
                int column = (mine / columns);
                int row = (mine % columns);
                if (row == 0 && mine != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                playGround[column, row - 1] = '*';
            }

            return playGround;
        }

        private static void smetki(char[,] ground)
        {
            int col = ground.GetLength(0);
            int row = ground.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (ground[i, j] != '*')
                    {
                        char total = CountMinesIn(ground, i, j);
                        ground[i, j] = total;
                    }
                }
            }
        }

        private static char CountMinesIn(char[,] board, int row, int column)
        {
            int counter = 0;
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, column] == '*')
                {
                    counter++;
                }
            }
            if (row + 1 < rows)
            {
                if (board[row + 1, column] == '*')
                {
                    counter++;
                }
            }
            if (column - 1 >= 0)
            {
                if (board[row, column - 1] == '*')
                {
                    counter++;
                }
            }
            if (column + 1 < columns)
            {
                if (board[row, column + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (board[row - 1, column - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (board[row - 1, column + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (board[row + 1, column - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (board[row + 1, column + 1] == '*')
                {
                    counter++;
                }
            }
            return char.Parse(counter.ToString());
        }
    }
}
