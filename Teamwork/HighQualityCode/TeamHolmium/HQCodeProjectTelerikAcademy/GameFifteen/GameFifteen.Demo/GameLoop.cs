using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameFifteen;

namespace GameFifteen.Demo
{
    class GameLoop
    {
        public static void Main(String[] args)
        {
            PlayBoard playBoard = new PlayBoard();
            ScoreBoard scoreBoard = new ScoreBoard();

            Game game = new Game(playBoard, scoreBoard);
        }
    }
}
