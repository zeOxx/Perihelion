using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perihelion.Models
{
    class Gameworld         // TODO SINGLETON
    {
        private Player[] playerObject;

        public Player[] getPlayer()
        {
            playerObject[0] = new Player();
            return playerObject;
        }


    }
}
