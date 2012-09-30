using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Perihelion
{
    class HUD
    {
        /************************************************************************/
        /* Preparing objects                                                    */
        /************************************************************************/
        Models.Interface HealthBar;
        Models.Interface AuxBar;
        Models.Interface Special;

        /************************************************************************/
        /* Positional vectors                                                   */
        /************************************************************************/
        // THESE ARE ZERO BECAUSE THE CAMERA IS NOT IN PLACE YET.
        Vector2 healthBarPosition = Vector2.Zero;
        Vector2 auxBarPosition = Vector2.Zero;
        Vector2 specialPosition = Vector2.Zero;

        /************************************************************************/
        /* Constructor                                                          */
        /************************************************************************/
        public HUD()
        {
            // TODO:
            // Textures for the objects are not being set yet. so fix it!

            /*
             * Since textures are not set and placement is still there these do not work, so I commented them out.
             * 
            HealthBar = new Models.Interface(ContentHolder.healthBar, healthBarPosition.X, healthBarPosition.Y, null, null);
            AuxBar = new Models.Interface(ContentHolder.auxBar, auxBarPosition.X, auxBarPosition.Y, null, null);
            Special = new Models.Interface(ContentHolder.special, specialPosition.X, specialPosition.Y, null, null);
             */
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
            HealthBar.Draw(spriteBatch);
            AuxBar.Draw(spriteBatch);
            Special.Draw(spriteBatch);
        }
    }
}
