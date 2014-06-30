using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisMatchCodingDojo {
    public class GameScores {
        private GameScore gameScoreSpelerEen;
        private GameScore gameScoreSpelerTwee;

        public GameScores() {
            gameScoreSpelerEen = GameScore.zero;
            gameScoreSpelerTwee = GameScore.zero;
        }

        public void Win(Speler speler, Games games) {
            if (speler == Speler.Een) {
                WinVoorSpeler(ref gameScoreSpelerEen, ref gameScoreSpelerTwee, speler, games);
                return;
            }
            WinVoorSpeler(ref gameScoreSpelerTwee, ref gameScoreSpelerEen, speler, games);  
        }

        private void WinVoorSpeler(ref GameScore gameScore, ref GameScore andereGameScore, Speler speler, Games games) {
            if (gameScore != GameScore.forty && gameScore != GameScore.advantage) {
                gameScore = gameScore.Next();
                return;
            }
            if (gameScore == GameScore.forty && andereGameScore == GameScore.forty) {
                gameScore = GameScore.advantage;
                return;
            }
            if (andereGameScore == GameScore.advantage) {
                andereGameScore = GameScore.forty;
                return;
            }
            gameScore = GameScore.zero;
            andereGameScore = GameScore.zero;
            games.Win(speler);
        }

        public override string ToString() {
            return String.Format("{0} {1}", gameScoreSpelerEen, gameScoreSpelerTwee);
        }
    }
}
