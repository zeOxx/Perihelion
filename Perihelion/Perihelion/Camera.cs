using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Perihelion
{
    
    class Camera
    {
        public Matrix transform;
        Viewport view;
        Vector2 center;
        float zoom;
        float rotation;

        //Constructor updates the view
        public Camera(Viewport view)
        {
            this.view = view;
            this.zoom = 1.0f;
            this.center = Vector2.Zero;
        }

        public float Zoom
        {
            get { return this.zoom; }
            set { this.zoom = value; }
        }

        public Matrix Transform
        {
            get { return this.transform; }
            set { this.transform = value; }
        }

        public Vector2 Center
        {
            get { return this.center; }
            set { this.center = value; }
        }
        public void update(GameTime gameTime, cameraTest picture)
        {
            
            MathHelper.Clamp(this.zoom, 0.01f, 10.0f);
            
            this.center = new Vector2(picture.spritePosition.X + (picture.spriteRectangle.Width / 2 -  400)
            ,picture.spritePosition.Y + (picture.spriteRectangle.Height / 2 - 250));

            this.transform = Matrix.CreateScale(new Vector3(this.zoom, this.zoom, 1)) *
                Matrix.CreateTranslation(new Vector3(-center.X, -center.Y, 0));
        }
    }
}

