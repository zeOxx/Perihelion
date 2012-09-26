﻿using System;
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
        Vector2 getPosition (){
            return position;
        }

        Vector2 getVelocity()
        {
            return this.velocity;
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