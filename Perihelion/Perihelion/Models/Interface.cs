using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Perihelion.Models
{
    class Interface : GameObject
    {
        // This determines the placement of the interface element. This tells HUD.cs where to draw it.
        String placement;

        /************************************************************************/
        /* Constructor                                                          */
        /************************************************************************/
        public Interface(Texture2D texture, float x, float y, Vector2 velocity, String placement) 
            : base(texture, x, y, velocity)
        {
            setPlacement(placement);
        }

        /************************************************************************/
        /* Setters                                                              */
        /************************************************************************/
        private void setPlacement(String placement)
        {
            this.placement = placement;
        }

        /************************************************************************/
        /* Getters                                                              */
        /************************************************************************/
        public String getPlacement()
        {
            return placement;
        }
    }
}
