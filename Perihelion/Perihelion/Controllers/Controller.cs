using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Perihelion.Models;
using Perihelion;


namespace Perihelion.Controllers
{
    class Controller
    {
        
        //************** VARIABLES ******************
        private GameObject[] playerObjects;

        public Controller()
        {
            playerObjects = new GameObject[Constants.maxNumberOfObjectsInArray];
        }

        //************** FUNCTIONS ******************
        
        public Gameworld updateGameWorld(Gameworld gameWorld)
        {
            getModelFromGameworld(gameWorld);

            return gameWorld;
        }

        //Copies the entire Gamestate
        public void getModelFromGameworld(Gameworld gameWorld)
        {
            playerObjects = gameWorld.getPlayer();
        }

    }
}
