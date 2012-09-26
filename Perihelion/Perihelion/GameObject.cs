using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Perihelion
{
    class GameObject
    {
        public Texture2D texture;
        public Vector2 position = new Vector2();
        public float velocity;
        public int direction;

        public GameObject () {
            
        }
    }
}
