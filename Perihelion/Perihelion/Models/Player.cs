using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Perihelion.Models
{
    class Player : Unit
    {
        private float wellMultiplier;
        private int wellStatus;

        /************************************************************************/
        /*  Constructors for Player object                                      */
        /************************************************************************/
        public Player(Texture2D texture, float x, float y, Vector2 velocity, int currentHealth, int maxHealth)
            : base(texture, x, y, velocity, currentHealth, maxHealth)
        {
            setWellMultiplier(1);
            setWellStatus(0);
        }

        public Player(Texture2D texture, float x, float y, Vector2 velocity, int currentHealth, int maxHealth, float damageMultiplier, float attackMultiplier, float wellMultiplier, int wellStatus)
            : base(texture, x, y, velocity, currentHealth, maxHealth, damageMultiplier, attackMultiplier)
        {
            setWellMultiplier(wellMultiplier);
            setWellStatus(wellStatus);
        }
        /************************************************************************/
        /*  Set functions for Player attributes                                 */
        /************************************************************************/
        void setWellMultiplier(float wellModifier)
        {
            this.wellMultiplier = wellModifier;
        }

        void setWellStatus(int wellStatus)
        {
            this.wellStatus = wellStatus;
        }

        /************************************************************************/
        /*  Get functions for Player attributes                                 */
        /************************************************************************/
        float getWellMultiplier()
        {
            return this.wellMultiplier;
        }

        int getWellStatus()
        {
            return wellStatus;
        }
    }
}
