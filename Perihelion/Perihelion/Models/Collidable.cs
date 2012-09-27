using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Perihelion.Models
{
    class Collidable : GameObject
    {
        bool isDestructable;
        int maxHealth;
        int currentHealth;

        /************************************************************************/
        /* Constructor                                                          */
        /************************************************************************/
        public Collidable(Texture2D texture, float x, float y, Vector2 velocity, bool isDestructable, int maxHealth, int currentHealth) : base(texture, x, y, velocity)
        {
            setDestructable(isDestructable);
            setMaxHealth(maxHealth);
            setCurrentHealth(currentHealth);
        }

        /************************************************************************/
        /* Setters                                                              */
        /************************************************************************/
        private void setDestructable(bool isDestructable)
        {
            this.isDestructable = isDestructable;
        }

        private void setMaxHealth(int maxHealth)
        {
            this.maxHealth = maxHealth;
        }

        private void setCurrentHealth(int currentHealth)
        {
            this.currentHealth = currentHealth;
        }

        /************************************************************************/
        /* Getters                                                              */
        /************************************************************************/
        public bool getDestructable()
        {
            return isDestructable;
        }

        public int getMaxHealth()
        {
            return maxHealth;
        }

        public int getCurrentHealth()
        {
            return currentHealth;
        }

        /************************************************************************/
        /* Misc                                                                 */
        /************************************************************************/
        public void updateCurrentHealth(int healthChange)
        {
            if (healthChange < 0)
                currentHealth -= healthChange;
            else
                currentHealth += healthChange;
        }
    }
}
