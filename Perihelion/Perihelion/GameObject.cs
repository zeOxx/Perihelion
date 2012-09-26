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

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        public GameObject (Texture2D texture, float x, float y, float velocity, int direction)
        {
            setTexture(texture);
            setPosition(x, y);
            setVelocity(velocity);
            setDirection(direction);
        }

        ~GameObject ()
        {

        }

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        void setTexture (Texture2D texture)
        {
            this.texture = texture;
        }

        void setPosition (float x, float y)
        {
            this.position = new Vector2(x, y);
        }

        void setVelocity (float velocity)
        {
            this.velocity = velocity;
        }

        void setDirection (int direction)
        {
            this.direction = direction;
        }
    }
}
