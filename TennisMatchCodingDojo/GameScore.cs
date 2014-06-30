using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisMatchCodingDojo {
    public class GameScore {
        public static GameScore zero = new GameScore("0");
        public static GameScore fifteen = new GameScore("15");
        public static GameScore thirty = new GameScore("30");
        public static GameScore forty = new GameScore("40");
        public static GameScore advantage = new GameScore("A");

        public String gameScore;

        private GameScore(String gameScore) {
            this.gameScore = gameScore;
        }

        public override string ToString() {
            return gameScore;
        }

        public GameScore Next() {
            if (this == zero) {
                return fifteen;
            }
            if (this == fifteen) {
                return thirty;
            }
            if (this == thirty) {
                return forty;
            }
            throw new NotImplementedException();
        }
    }
}
