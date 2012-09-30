using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Perihelion
{
    class Camera
    {
        public Matrix transform;
        Viewport view;
        Vector2 center;

        //Constructor updates the view
        public Camera(Viewport view)
        {
            this.view = view;
        }

        public void update(GameTime gameTime, cameraTest picture)
        {
            this.center = new Vector2(picture.spritePosition.X + (picture.spriteRectangle.Width / 2) - 400, 0);

            /*this.center = new Vector2(ship.spritePosition.X + (ship.spriteRectangle.Width / 2 -  400)
                ,ship.spritePosition.Y + (ship.spriteRectangle.Height / 2 - 250));*/

            this.transform = Matrix.CreateScale(new Vector3(1, 1, 0)) *
                Matrix.CreateTranslation(new Vector3(-center.X, -center.Y, 0));
        }
    }
}

