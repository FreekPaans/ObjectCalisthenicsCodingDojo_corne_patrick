using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisMatchCodingDojo
{
    public class TennisMatch
    {
        private Games games;
        private GameScores gameScores;

        public TennisMatch() {
            games = new Games();
            gameScores = new GameScores();
        }

        public String BerekenScore() {
            return String.Format("{0} {1}", games, gameScores);
        }

        public void ScorePuntVoor(Speler speler) {
            gameScores.Win(speler, games);
        }
    }
}
