using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisMatchCodingDojo {
    public class Game {
        private int wins;

        public void Win() {
            wins++;
        }

        public override String ToString() {
            return wins.ToString();
        }
    }
}
