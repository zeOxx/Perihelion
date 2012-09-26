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
        private float wellStrength;
        private bool wellStatus;
        private int currentHealth;
        private int maxHealth;

        /************************************************************************/
        /*  Constructor for Player object                                       */
        /************************************************************************/
        public Player(Texture2D texture, float x, float y, Vector2 velocity, float wellStrength, int currentHealth, int maxHealth)
            : base(texture, x, y, velocity)
        {
            setWellStrength(wellStrength);
            setWellStatus(false);
            setHealth(currentHealth, maxHealth);
        }

        /************************************************************************/
        /*  Set functions for Player attributes                                 */
        /************************************************************************/
        void setWellStrength(float wellStrength)
        {
            this.wellStrength = wellStrength;
        }

        void setWellStatus(bool wellStatus)
        {
            this.wellStatus = wellStatus;
        }

        void setHealth(int currentHealth, int maxHealth)
        {
            this.currentHealth = currentHealth;
            this.maxHealth = maxHealth;
        }

        /************************************************************************/
        /*  Get functions for Player attributes                                 */
        /************************************************************************/
        float getWellStrength()
        {
            return this.wellStrength;
        }

        bool getWellStatus()
        {
            return wellStatus;
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
