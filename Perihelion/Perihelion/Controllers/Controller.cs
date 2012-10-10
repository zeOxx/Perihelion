using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Perihelion.Models;
using Perihelion;


namespace Perihelion.Controllers
{
    class Controller
    {
        
        //************** VARIABLES ******************
        private Player playerObject;
        private Projectile bullets;

        public Controller()
        {
            //playerObject = new GameObject[Constants.maxNumberOfObjectsInArray];
            playerObject = null;
        }

        //************** FUNCTIONS ******************
        
        public Gameworld updateGameWorld(Gameworld gameWorld, GameTime gameTime, InputHandler inputHandler)
        {
            getModelFromGameworld(gameWorld);

            //Change gamestate

            checkInput(gameTime, inputHandler);

            gameWorld.setPlayer(playerObject);

            return gameWorld;
        }

        //Copies the entire Gamestate
        public void getModelFromGameworld(Gameworld gameWorld)
        {
            playerObject = gameWorld.getPlayer();
        }

        // Checks input
        public void checkInput(GameTime gameTime, InputHandler inputHandler)
        {
            //playerObject.updateVelocity(inputHandler.getMovementInputFromPlayer());
            //playerObject.updatePosition();

            playerObject.update(inputHandler.getMovementInputFromPlayer());



            //Temp input
            inputHandler.updateInput();
            
            if (inputHandler.KeyDown(Keys.D))
            {
                playerObject.updatePosition(1, 0);

            }

            if (inputHandler.KeyDown(Keys.A))
            {
                playerObject.updatePosition(-1, 0);

            }

            if (inputHandler.KeyDown(Keys.S))
            {
                playerObject.updatePosition(0, 1);
            }


            if (inputHandler.KeyDown(Keys.W))
            {
                playerObject.updatePosition(0, -1);

            }
        }

        public void updateBullets(Vector2 motion)
        {

        }
    }
}
