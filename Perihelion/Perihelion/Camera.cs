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
        private Matrix transform;
        public Matrix Transform
        {
            get { return this.transform; }
        }

        private Vector2 center;
        private Viewport view;

        float zoom = 1.0f;

        public float Zoom
        {
            get { return this.zoom; }
            set { this.zoom = value; }
        }

        //Constructor updates the view
        public Camera(Viewport view)
        {
            this.view = view;
        }

        public void update(GameTime gameTime, cameraTest picture)
        {

            this.center = new Vector2(picture.spritePosition.X + (picture.spriteRectangle.Width / 2 - 400)
            , picture.spritePosition.Y + (picture.spriteRectangle.Height / 2 - 250));

            //this.transform = Matrix.CreateScale(new Vector3(this.zoom, this.zoom, 0)) *
            //Matrix.CreateTranslation(new Vector3(-this.center.X, -this.center.Y, 0));

            this.transform = Matrix.CreateTranslation(new Vector3(-this.center.X, -this.center.Y, 0)) *
                Matrix.CreateScale(new Vector3(this.zoom, this.zoom, 0)); //*
                //Matrix.CreateTranslation(new Vector3(this.view.Width / 2, this.view.Height / 2, 0));
        }
    }
}

