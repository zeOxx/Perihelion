using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
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
        public Texture2D texturePlayer;


        public ContentHolder(ContentManager content)
        {   
            texturePlayer = content.Load<Texture2D>("texturePlayer");

        }
    }

    
}
