using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSPROEKT
{
    [Serializable]
    public class ListOfPlayers
    {
        public ListOfPlayers()
        {
            players = new List<Player>();
        }

        public List<Player> players;

    }
}
