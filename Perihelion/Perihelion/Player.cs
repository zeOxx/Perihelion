using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Perihelion
{
    class Player : GameObject
    {
        private float gravity;
        private int currentHealth;
        private int maxHealth;

        /************************************************************************/
        /*  Constructor for Player object                                       */
        /************************************************************************/
        public Player(Texture2D texture, float x, float y, Vector2 velocity, float gravity, int currentHealth, int maxHealth)
            : base(texture, x, y, velocity)
        {
            setGravity(gravity);
            setHealth(currentHealth, maxHealth);
        }

        /************************************************************************/
        /*  Set functions for Player attributes                                 */
        /************************************************************************/
        void setGravity(float gravity)
        {
            this.gravity = gravity;
        }

        void setHealth(int currentHealth, int maxHealth)
        {
            this.currentHealth = currentHealth;
            this.maxHealth = maxHealth;
        }

        /************************************************************************/
        /*  Get functions for Player attributes                                 */
        /************************************************************************/
        float getGravity()
        {
            return this.gravity;
        }

        int getCurrentHealth()
        {
            return this.currentHealth;
        }

        int getMaxHealth()
        {
            return this.maxHealth;
        }
    }
}
