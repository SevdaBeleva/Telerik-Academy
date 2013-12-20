using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteen
{
    public class Game
    {

        /*==========================================*/
        /*          Game Fields
        /*==========================================*/

        private PlayBoard playBoard;
        private ScoreBoard scoreBoard;

        /*==========================================*/
        /*          Game Constructor
        /*==========================================*/

        public Game(PlayBoard playBoard, ScoreBoard scoreBoard)
        {
            PlayBoard = playBoard;
            ScoreBoard = scoreBoard;

            this.StartGame();
        }

        /*==========================================*/
        /*          Game Propertys
        /*==========================================*/

        public PlayBoard PlayBoard
        {
            get 
            { 
                return playBoard; 
            }
            private set 
            { 
                playBoard = value;
            }
        }

        public ScoreBoard ScoreBoard
        {
            get 
            { 
                return scoreBoard; 
            }
            private set 
            { 
                scoreBoard = value;
            }
        }

        /*==========================================*/
        /*          Game Methods
        /*==========================================*/

        /// <summary>
        ///  Loop the game object and wait for user input 
        ///  1. System command
        ///  2. Numeric game command
        /// </summary>
        public void GameLoop()
        {
            while (true)
            {
                ReadInput();
            }
        }

        /// <summary>
        /// Initiate game object by creating new PlayBoard object and starting the game loop
        /// </summary>
        public void StartGame()
        {
            Console.Clear();

            Console.WriteLine("Welcome to the game “15”. Please try to arrange the numbers sequentially");
            Console.WriteLine("-> Use 'score' to view the top scoreboard");
            Console.WriteLine("-> Use 'restart' to start a new game ");

            PlayBoard.PlayBoardGenerator();
            PlayBoard.MoveCount = 0;
            Console.WriteLine(PlayBoard);
            GameLoop();
        }

        /// <summary>
        /// Read user input and assign different methods to execute required tasks
        /// </summary>
        public void ReadInput()
        {
            Console.Write("Enter a number to move: ");
            string input = Console.ReadLine();

            if (IsNumberInput(input))
            {
                BoardMove(input);
            }
            else
            {
                SystemInput(input);
            }
        }


        /// <summary>
        /// Check if the user input is string command or GameBoard numeric move
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsNumberInput(string input)
        {

            int numberResult;
            bool isNumberInput = int.TryParse(input, out numberResult);

            return isNumberInput;
        }

        /// <summary>
        /// Control user input and play, get user input validate it and 
        /// if the game ends, show the required text messages
        /// </summary>
        public void BoardMove(string input)
        {
            int numberInput = int.Parse(input);

            if (PlayBoard.MoveNumber(numberInput))
            {
                if (!PlayBoard.IsMoveInBoardRange())
                {
                    Console.WriteLine(PlayBoard);
                }
                else
                {
                    ScoreEnter();
                    GameRestart();
                }
            }
            else
            {
                Console.WriteLine("Illegal move");
            }
        }

        /// <summary>
        /// Initiate new StartGame 
        /// </summary>
        public void GameRestart()
        {
            StartGame();
        }

        /// <summary>
        ///  Show ScoreBoard through score object
        /// </summary>
        public void GameScore()
        {
            Console.WriteLine(ScoreBoard);
        }

        /// <summary>
        /// Get score input, validate input data and set the new score entry
        /// </summary>
        public void ScoreEnter()
        {
            Console.WriteLine("Congratulations! You won the game in {0} moves.", PlayBoard.MoveCount);
            Console.Write("Enter your Name enter : ");
            string nameInput = Console.ReadLine();
            ScoreBoard.SetPlayerScore(nameInput, PlayBoard.MoveCount);
        }


        /// <summary>
        ///  Control system inputs through string commands:
        ///  1. Restart command
        ///  2. Show ScoreBoard command
        /// </summary>
        /// <param name="input"></param>
        public void SystemInput(string input)
        {
            switch (input)
            {
                case "restart":
                    GameRestart();
                    break;
                case "score":
                    GameScore();
                    break;
                default:
                    Console.WriteLine("Illegal command try again!");
                    break;
            }
        }
    }
}
