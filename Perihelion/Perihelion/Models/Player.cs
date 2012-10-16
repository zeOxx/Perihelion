using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Perihelion.Models
{
    class Player : Unit
    {
        private float wellMultiplier;
        private int wellStatus;
        private int auxiliaryPower;
        

        /************************************************************************/
        /*  Constructors for Player object                                      */
        /************************************************************************/
        public Player()
            : base()
        {
            setWellMultiplier(1);
            setWellStatus(0);
            setAuxiliaryPower(100);
        }

        public Player(Texture2D texture, float x, float y, Vector2 velocity, int currentHealth, int maxHealth)
            : base(texture, x, y, velocity, currentHealth, maxHealth)
        {
            setWellMultiplier(1);
            setWellStatus(0);
            setAuxiliaryPower(100);

            // Temp
            setSpeed(5);
            setMaxSpeed(5);
        }

        public Player(Texture2D texture, float x, float y, Vector2 velocity, int currentHealth, int maxHealth, float damageMultiplier, float attackMultiplier, float wellMultiplier, int wellStatus, int auxiliaryPower)
            : base(texture, x, y, velocity, currentHealth, maxHealth, damageMultiplier, attackMultiplier)
        {
            setWellMultiplier(wellMultiplier);
            setWellStatus(wellStatus);
            setAuxiliaryPower(auxiliaryPower);
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

        void setAuxiliaryPower(int auxiliaryPower)
        {
            this.auxiliaryPower = auxiliaryPower;
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
            return this.wellStatus;
        }

        int getAuxiliaryPower()
        {
            return this.auxiliaryPower;
        }

        /************************************************************************/
        /*  Update functions for Player attributes                              */
        /************************************************************************/
        public void updateWellMultiplier(float i)
        {
            this.wellMultiplier += i;
        }

        public void updateAuxiliaryPower(int i)
        {
            this.auxiliaryPower += i;
        }

        

        // WUT
//         /************************************************************************/
//         /*  Constructor functions for Player attributes                         */
//         /************************************************************************/
// 
//         public void constructPlayer(Texture2D texture, float x, float y, Vector2 velocity, int currentHealth, int maxHealth, float damageMultiplier, float attackMultiplier, float wellMultiplier, int wellStatus, int auxiliaryPower)
//         {
//             base.constructUnit(texture, x, y, velocity, currentHealth, maxHealth, damageMultiplier, attackMultiplier);
//             setWellMultiplier(wellMultiplier);
//             setWellStatus(wellStatus);
//             setAuxiliaryPower(auxiliaryPower);
//         }
    }
}
