using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace Perihelion
{
    public class cameraTest : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D spriteTexture;
        public Rectangle spriteRectangle;

        //Center of the image
        Vector2 spriteOrigin;

        public Vector2 spritePosition;
        float rotation;
        float zoom;

        Vector2 spriteVelocity;
        const float TANGENTIALVELOCITY = 5.0f;
        float friction = 0.1f;

        //Camera object
        Camera camera;

        //For drawing
        Texture2D backgroundTexture;
        Vector2 backgroundPosition;     //Not in use right now...


        public cameraTest()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            camera = new Camera(GraphicsDevice.Viewport);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Loads the awesome pirate-ship picture
            spriteTexture = Content.Load<Texture2D>("texturePlayer");

            //Defines the size
            spritePosition = new Vector2(300, 250);

            //Same goes for background
            backgroundTexture = Content.Load<Texture2D>("background");

        }


        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            spriteRectangle = new Rectangle((int)spritePosition.X, (int)spritePosition.Y, spriteTexture.Width, spriteTexture.Height);
            spritePosition = spriteVelocity + spritePosition;

            spriteOrigin = new Vector2(spriteRectangle.Width / 2, spriteRectangle.Height / 2);

            if (Keyboard.GetState().IsKeyDown(Keys.X)) zoom += 1.0f;
            if (Keyboard.GetState().IsKeyDown(Keys.Z)) zoom -= 1.0f;

            if (Keyboard.GetState().IsKeyDown(Keys.Right)) rotation += 0.1f;
            if (Keyboard.GetState().IsKeyDown(Keys.Left)) rotation -= 0.1f;

            if (Keyboard.GetState().IsKeyDown(Keys.Up)) //If we stop (release key)
            {
                spriteVelocity.X = (float)Math.Cos(rotation) * TANGENTIALVELOCITY;
                spriteVelocity.Y = (float)Math.Sin(rotation) * TANGENTIALVELOCITY;
            }
            else if (spriteVelocity != Vector2.Zero)    
            {
                float i = spriteVelocity.X;
                float j = spriteVelocity.Y;

                spriteVelocity.X = i -= friction * i;
                spriteVelocity.Y = j -= friction * j;
            }

            camera.update(gameTime, this);
            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);   //Backgroundcolor if you move outside the background-picture

            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, camera.Transform);

            //Background
            spriteBatch.Draw(backgroundTexture, backgroundPosition, Color.White);

            //Ship-picture
            spriteBatch.Draw(spriteTexture, spritePosition, null, Color.White, rotation, spriteOrigin, 1f, SpriteEffects.None, 0.0f);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
