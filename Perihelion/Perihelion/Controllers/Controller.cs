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
        private GameObject playerObject;


        public Controller()
        {
            //playerObject = new GameObject[Constants.maxNumberOfObjectsInArray];
            playerObject = null;
        }

        //************** FUNCTIONS ******************
        
        public Gameworld updateGameWorld(Gameworld gameWorld)
        {
            getModelFromGameworld(gameWorld);

            //Change gamestate

            return gameWorld;
        }

        //Copies the entire Gamestate
        public void getModelFromGameworld(Gameworld gameWorld)
        {
            playerObject = gameWorld.getPlayer();
        }

    }
}
