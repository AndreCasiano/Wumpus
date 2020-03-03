using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class HighScore
    {
        // instance variables
        private int newHighScore;  // to assign value to high score received from user

        
        public HighScore()
        {
            // default high score data for the game should be the names of all of the participants in this project, with zero scores and arbitrary cave names.
            int[][] highScore = new int[6][];
            highScore[0] = new int[0];  // default high score data for all participants in project; all start with 0
            highScore[1] = new int[0];
            highScore[2] = new int[0];
            highScore[3] = new int[0];
            highScore[4] = new int[0];
            highScore[5] = new int[0];
            //return default(HighScore);
        }

        public int[] getHighScores(int[] updateHS)
        {
            // it will call for score from player
            // and update default scores
            // will also add new score
            return updateHS;
          
        }

        public int viewingExistingScores()
        {
            // Viewing existing high scores
            // will open existing high scores (I'm not entirely sure how to implement that)
            return 0;
        }

        public int replaceLowestScoreWhenFull(int newScore)
        {
            // if all 10 scores are tracked/occupied, and a new score is drawn in, replace that with the lowest score (10th position)
            return newScore;
        }
        public int calculateHighScore()
        {
            return 0;
        }


        /* The user will interact with this component in two ways:
              Storing a new high score
              Viewing existing high scores
           The default high score data for the game should be the names of all of the
           participants in this project, with zero scores and arbitrary cave names.
           the user will be able to bring up the high score table 
           through the game’s menu system, and the high score table will 
           automatically be displayed after a player finishes a game.

        At no time will there be more than 10 scores tracked by the High Score Management System. 
        If a new score is submitted, that is good enough to be included in an already-full high score table,
        the new score will cause the lowest other score to be removed automatically.
         */






    }
}
