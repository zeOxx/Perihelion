using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework;

namespace Perihelion
{
    class Input
    {
        private float vibrationAmount = 0.0f;

        void UpdateInput()
        {
            // Get the current gamepad state.
            GamePadState currentState = GamePad.GetState(PlayerIndex.One);

            // Process input only if connected and button A is pressed.
//             if (currentState.IsConnected && currentState.Buttons.A ==
//                 ButtonState.Pressed)
//             {
//                 // Button A is currently being pressed; add vibration.
//                 vibrationAmount =
//                     MathHelper.Clamp(vibrationAmount + 0.03f, 0.0f, 1.0f);
//                 GamePad.SetVibration(PlayerIndex.One,
//                     vibrationAmount, vibrationAmount);
//             }
//             else
//             {
//                 // Button A is not being pressed; subtract some vibration.
//                 vibrationAmount =
//                     MathHelper.Clamp(vibrationAmount - 0.05f, 0.0f, 1.0f);
//                 GamePad.SetVibration(PlayerIndex.One,
//                     vibrationAmount, vibrationAmount);
//             }
        }
    }
}
