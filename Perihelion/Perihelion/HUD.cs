using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Perihelion
{
    class HUD
    {
        /************************************************************************/
        /* Preparing objects                                                    */
        /************************************************************************/
        Models.Interface HealthAuxBar;
        //Models.Interface Special;

        /************************************************************************/
        /* Positional vectors                                                   */
        /************************************************************************/
        // THESE ARE ZERO BECAUSE THE CAMERA IS NOT IN PLACE YET.
        Vector2 healthBarAuxPosition;
        //Vector2 specialPosition = Vector2.Zero;

        /************************************************************************/
        /* Constructor                                                          */
        /************************************************************************/
        public HUD(ContentHolder contentHolder, Vector2 camCenter, Camera camera)
        {
            setHudPositions(camCenter, camera);

            HealthAuxBar = new Models.Interface(contentHolder.healthAuxBar, healthBarAuxPosition.X, healthBarAuxPosition.Y, new Vector2(0, 0));
        }

        /************************************************************************/
        /* Methods                                                              */
        /************************************************************************/
        public void update()
        {
            // Calls update to all the objects to check health etc for the player. Yet to be implemented
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            HealthAuxBar.Draw(spriteBatch);
            //Special.Draw(spriteBatch);
        }

        public void setHudPositions(Vector2 camCenter, Camera camera)
        {
            healthBarAuxPosition = new Vector2((camCenter.X - camera.View.Width/2) - 10, 
                                                (camCenter.Y - camera.View.Height/2) - 10);
        }

        public void updateHudPositions(Vector2 camCenter)
        {

        }
    }
}
