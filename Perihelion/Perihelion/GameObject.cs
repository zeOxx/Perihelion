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
        private Texture2D texture;
        private Vector2 position = new Vector2();
        private Vector2 velocity;

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        public GameObject (Texture2D texture, float x, float y, Vector2 velocity)
        {
            setTexture(texture);
            setPosition(x, y);
            setVelocity(velocity);
        }

        /************************************************************************/
        /*  Creates a boundingbox based on the texture                          */
        /************************************************************************/
        public Rectangle BoundingBox
        {
            get
            {
                return new Rectangle(
                    (int)position.X,
                    (int)position.Y,
                    texture.Width,
                    texture.Height);
            }
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

        void setVelocity (Vector2 velocity)
        {
            this.velocity = velocity;
        }

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        public Vector2 getPosition ()
        {
            return position;
        }

        public Vector2 getVelocity()
        {
            return this.velocity;
        }

        public Texture2D getTexture()
        {
            return texture;
        }

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        void update (float x, float y, Vector2 velocity)
        {
            updatePosition(x, y);
            updateVelocity(velocity);
        }

        void updatePosition(float x, float y)
        {
            this.position = new Vector2(x, y);
        }

        void updateVelocity(Vector2 velocity)
        {
            this.velocity = velocity;
        }
    }
}