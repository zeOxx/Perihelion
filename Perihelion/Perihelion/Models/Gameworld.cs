using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perihelion.Models
{
    class Gameworld         // TODO SINGLETON
    {


        private Player playerObject;


        public Gameworld()
        {
            initializeGameworld();
            
        }

        public Player getPlayer()
        {
            
            return playerObject;
        }

        private void initializeGameworld()
        {
            playerObject = new Player();
        }

    }
}
