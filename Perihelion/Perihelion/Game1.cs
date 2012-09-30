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
using Perihelion.Models;
using Perihelion.Controllers;

namespace Perihelion
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        Gameworld gameWorld;
        Controller gameController;
        ContentHolder contentHolder;
//         Controllers.Controller gameController = new Controllers.Controller();
//         Models.Gameworld gameWorld = new Models.Gameworld(); 

        // The two declarations below are used for testing purposes!
        GameObject testObject;
        Vector2 tempVector = Vector2.Zero;

        private int height = 720;
        private int width = 1280;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferHeight = height;
            graphics.PreferredBackBufferWidth = width;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            gameController = new Controllers.Controller();
            gameWorld = new Models.Gameworld();    //TODO SINGLETON
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            contentHolder = new ContentHolder(this.Content);

            // THIS IS JUST A TEST THING. THIS IS NOT THE KOSHER WAY TO DRAW AN OBJECT WITH THE WAY THE PROJECT IS CURRENTlY SET UP!
            //testObject = new GameObject(Content.Load<Texture2D>("texturePlayer"), (width/2-16), (height/2-16), tempVector);

            testObject = new GameObject(contentHolder.texturePlayer, (width / 2 - 16), (height / 2 - 16), tempVector);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {


            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // Stores the keyboardstate in a variable
            KeyboardState keyboard = Keyboard.GetState();

            // Exits the game when ESC is pressed
            if (keyboard.IsKeyDown(Keys.Escape))
                Exit();

            // Sends gamestate to controller and receives updated state. 
            gameWorld = gameController.updateGameWorld(gameWorld);

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            testObject.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
