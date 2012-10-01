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
    class ContentHolder : Microsoft.Xna.Framework.Game
    {
        // Playertexture
        public Texture2D texturePlayer;
        public Texture2D textureRock01;

        // HUD elements
        public Texture2D healthbar;
        public Texture2D auxBar;
        public Texture2D special;

        public ContentHolder(ContentManager content)
        {   
            texturePlayer = content.Load<Texture2D>("texturePlayer");
            textureRock01 = content.Load<Texture2D>("rock_01");
            /*
             * healthBar = content.Load<Texture2D>("healthbar");
             * auxBar = content.Load<Texture2D>("auxbar");
             * special = content.Load<Texture2D>("special");
             */
        }
    }
}
