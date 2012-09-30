using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework;

namespace Perihelion
{
    class InputHandler : GameComponent
    {
        // Sets vibration to 0. CURRENTLY NOT IN USE!
        private float vibrationAmount = 0.0f;

        // Sets up different states for the gamepad
        static GamePadState currentGamePadState;
        static GamePadState lastGamePadState;
        // Sets up different states for the keyboard
        static KeyboardState currentKeyboardState;
        static KeyboardState lastKeyboardState;

        // NOT 100% SURE ON WETHER THESE ARE NEEDED OR IF IT IS JUST AN EXTRA THING
        //  BEGIN UNSUREDNESS
        public static KeyboardState KeyboardState
        {
            get { return currentKeyboardState; }
        }

        public static KeyboardState LastKeyboardState
        {
            get { return lastKeyboardState; }
        }

        public static GamePadState GamePadState
        {
            get { return currentGamePadState; }
        }

        public static GamePadState LastGamePadState
        {
            get { return lastGamePadState; }
        }
        // END UNSUREDNESS

        /************************************************************************/
        /* Constructor                                                          */
        /************************************************************************/
        public InputHandler(Game game) : base(game)
        {
            currentKeyboardState = Keyboard.GetState();

            currentGamePadState = GamePad.GetState(PlayerIndex.One);
        }

        /************************************************************************/
        /* XNA OVERRIDES                                                        */
        /************************************************************************/
        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            // Updates the current and last keyboardstates
            lastKeyboardState = currentKeyboardState;
            currentKeyboardState = Keyboard.GetState();

            // Updates the current and last gamepadstates
            lastGamePadState = currentGamePadState;
            currentGamePadState = GamePad.GetState(PlayerIndex.One);

            base.Update(gameTime);
        }

        /************************************************************************/
        /* KEYBOARD METHODS                                                     */
        /************************************************************************/
        public static void Flush()
        {
            lastKeyboardState = currentKeyboardState;
        }

        public static bool KeyReleased(Keys key)
        {
            // Returns if the released key was the same key that was pressed
            return currentKeyboardState.IsKeyUp(key) && lastKeyboardState.IsKeyDown(key);
        }

        public static bool KeyDown(Keys key)
        {
            // Returns the key that is currently pressed down
            return currentKeyboardState.IsKeyDown(key);
        }

        /************************************************************************/
        /* GAMEPAD METHODS                                                      */
        /************************************************************************/
        public static bool ButtonReleased(Buttons button)
        {
            // Returns if the released button was the same button that was pressed
            return currentGamePadState.IsButtonUp(button) && lastGamePadState.IsButtonDown(button);
        }

        public static bool ButtonPressed(Buttons button)
        {
            // Returns if the pressed button was not already being pressed
            return currentGamePadState.IsButtonDown(button) && lastGamePadState.IsButtonUp(button);
        }

        public static bool ButtonDown(Buttons button)
        {
            // Returns the button that is being pressed down.
            return currentGamePadState.IsButtonDown(button);
        }

        // TEMP STICK HANDLING
        public static float updateLeftStickX()
        {
            return currentGamePadState.ThumbSticks.Left.X;
        }

        public static float updateLeftStickY()
        {
            return currentGamePadState.ThumbSticks.Left.Y;
        }

        public static float updateRightStickX()
        {
            return currentGamePadState.ThumbSticks.Right.X;
        }

        public static float updateRightStickY()
        {
            return currentGamePadState.ThumbSticks.Right.Y;
        }
    }
}
