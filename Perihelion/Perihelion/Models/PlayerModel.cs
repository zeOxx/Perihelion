using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Perihelion.Models
{
    class Player : GameObject
    {
        private float wellMultiplier;
        private bool wellStatus;
        private int currentHealth;
        private int maxHealth;
        private float damageMultiplier;
        private float attackMultiplier;

        /************************************************************************/
        /*  Constructors for Player object                                      */
        /************************************************************************/
        public Player(Texture2D texture, float x, float y, Vector2 velocity, int currentHealth, int maxHealth)
            : base(texture, x, y, velocity)
        {
            setWellMultiplier(1);
            setWellStatus(false);
            setHealth(currentHealth, maxHealth);
            setDamageMultiplier(1);
            setAttackMultiplier(1);
        }

        public Player(Texture2D texture, float x, float y, Vector2 velocity, float wellMultiplier, int currentHealth, int maxHealth, float damageMultiplier, float attackMultiplier)
            : base(texture, x, y, velocity)
        {
            setWellMultiplier(wellMultiplier);
            setWellStatus(wellStatus);
            setHealth(currentHealth, maxHealth);
            setDamageMultiplier(damageMultiplier);
            setAttackMultiplier(attackMultiplier);
        }
        /************************************************************************/
        /*  Set functions for Player attributes                                 */
        /************************************************************************/
        void setWellMultiplier(float wellModifier)
        {
            this.wellMultiplier = wellModifier;
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

        void setDamageMultiplier(float damageMultiplier)
        {
            this.damageMultiplier = damageMultiplier;
        }

        void setAttackMultiplier(float attackMultiplier)
        {
            this.attackMultiplier = attackMultiplier;
        }

        /************************************************************************/
        /*  Get functions for Player attributes                                 */
        /************************************************************************/
        float getWellMultiplier()
        {
            return this.wellMultiplier;
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

        float getDamageMultiplier()
        {
            return this.damageMultiplier;
        }

        float getAttackMultiplier()
        {
            return this.attackMultiplier;
        }
    }
}
