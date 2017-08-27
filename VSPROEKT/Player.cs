using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSPROEKT
{

    [Serializable]
    public class Player
   {
      public string name;
      public int coins;

      public Player(string name) {
            this.name = name;
            this.coins = 10;
      }

        public override string ToString(){
            return string.Format("{0} {1}", name, coins);
        }

    }
}
