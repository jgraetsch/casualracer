using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasualRacer.Model
{
    internal class Game
    {
        public List<Player> Players { get; set; }

        public Game()
        {
            Players = new List<Player>();
        }
    }
}
