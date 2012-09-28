using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework;

namespace Perihelion
{
    class InputHandler
    {
        private float vibrationAmount = 0.0f;

        static GamePadState currentGamePadState;
        static GamePadState lastGamePadState;
        static KeyboardState currentKeyboardState;
        static KeyboardState lastKeyboardState;

        public static KeyboardState KeyboardState
        {
            get { return currentKeyboardState; }
        }
    }
}
