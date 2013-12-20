using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteen
{
    public class ScoreBoard
    {
        /*==========================================*/
        /*          ScoreBoard Fields
        /*==========================================*/

        private Dictionary<string, int> topPlayer = new Dictionary<string, int>();


        /*==========================================*/
        /*          ScoreBoard Propertys
        /*==========================================*/

        /// <summary>
        ///  Set User name and Scores base on number of  user Moves
        /// </summary>
        public Dictionary<string, int> TopPlayer
        {
            get
            {
                return topPlayer;
            }
            private set
            {
                topPlayer = value;
            }
        }

        /*==========================================*/
        /*          ScoreBoard Methods
        /*==========================================*/


        /// <summary>
        ///  Set New Player top Score this method use a Dictionary for Saving user name and Score in Key - Value structure
        ///  After saving new User, in the topPlayer Structure The leader board can be aranged.
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="playerScore"></param>
        public void SetPlayerScore(string playerName, int playerScore)
        {
            TopPlayer.Add(playerName, playerScore);
        }

        /// <summary>
        /// Print the Leader Board entries
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder scoreBoardBuilder = new StringBuilder();

            if (TopPlayer.Count != 0)
            {
                foreach (var item in TopPlayer.OrderBy(player => player.Value))
                {
                    scoreBoardBuilder.AppendFormat("{0} <-> {1}\n", item.Key, item.Value);
                }
            }
            else
            {
                scoreBoardBuilder.Append("No new entries yet.");
            }

            return scoreBoardBuilder.ToString();
        }

    }
}
