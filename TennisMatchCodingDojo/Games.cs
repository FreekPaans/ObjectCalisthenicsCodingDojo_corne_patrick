using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisMatchCodingDojo {
    public class Games {
        private Game gameSpelerEen;
        private Game gameSpelerTwee;

        public Games() {
            gameSpelerEen = new Game();
            gameSpelerTwee = new Game();
        }

        public void Win(Speler speler) {
            if (speler == Speler.Een) {
                gameSpelerEen.Win();
                return;
            }

            gameSpelerTwee.Win();
        }

        public override string ToString() {
            return String.Format("{0} {1}", gameSpelerEen.ToString(), gameSpelerTwee.ToString());
        }
    }
}
