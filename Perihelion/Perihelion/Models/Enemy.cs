﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Perihelion.Models
{
    class Enemy : Unit
    {
        bool projectiles;
        bool destructibleProjectiles;
        bool cloak;
        bool cloaked;
        int cloakCountdown;
        static int cloakCooldown = 100;

        /************************************************************************/
        /*  Constructors for Enemy object                                       */
        /************************************************************************/
        public Enemy(Texture2D texture, float x, float y, Vector2 velocity, int currentHealth, int maxHealth)
            : base(texture, x, y, velocity, currentHealth, maxHealth)
        {
            setProjectiles(true, true);
            this.cloak = false;
            setCloaked(false);
        }

        public Enemy(Texture2D texture, float x, float y, Vector2 velocity, int currentHealth, int maxHealth, float damageMultiplier, float attackMultiplier, bool projectiles, bool destructibleProjectiles, bool cloak)
            : base(texture, x, y, velocity, currentHealth, maxHealth, damageMultiplier, attackMultiplier)
        {
            setProjectiles(projectiles, destructibleProjectiles);
            this.cloak = cloak;
            this.cloakCountdown = 0;
            if (this.cloak)
            {
                setCloaked(true);
            }
            else
            {
                setCloaked(false);
            }
        }
        /************************************************************************/
        /*  Set functions for Enemy attributes                                  */
        /************************************************************************/
        void setProjectiles(bool projectiles, bool destructibleProjectiles)
        {
            this.projectiles = projectiles;
            this.destructibleProjectiles = destructibleProjectiles;
        }

        void setCloaked(bool cloaked)
        {
            if (!cloaked && getCloaked())
            {
                this.cloakCountdown = cloakCooldown;
                this.cloaked = cloaked;
            }
            else if (cloakCountdown > 0 && cloaked)
            {
                this.cloaked = cloaked;
            }
        }

        void setCloakcountdown(int i)
        {
            this.cloakCountdown -= i;
        }
        /************************************************************************/
        /*  Get functions for Enemy attributes                                  */
        /************************************************************************/
        bool getProjectiles()
        {
            return this.projectiles;
        }

        bool getDestructibleProjectiles()
        {
            return this.destructibleProjectiles;
        }

        bool getCloak()
        {
            return this.cloak;
        }

        bool getCloaked()
        {
            return this.cloaked;
        }
    }
}
