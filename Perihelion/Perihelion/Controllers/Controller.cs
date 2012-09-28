using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perihelion.Controllers
{
    class Controller : GameObject
    {
        
        //************** VARIABLES ******************
        private GameObject[] playerObjects;

        public Controller()
        {
            playerObjects = new GameObject[maxNumberOfObjectsInArray];
        }

        //************** FUNCTIONS ******************
        
        //Copies the entire Gamestate
        public void getModelFromGameworld()
        {
            playerObjects = .getPlayer();
        }

    }
}
