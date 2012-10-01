using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using Perihelion;

namespace Perihelion.Models
{
    class Gameworld : Microsoft.Xna.Framework.Game        // TODO SINGLETON
    {
        private Player playerObject;
        private Collidable rock;

        public Gameworld(ContentHolder contentHolder)
        {
            initializeGameworld(contentHolder);
        }

        public Player getPlayer()
        {
            return playerObject;
        }

        public void setPlayer(Player updatedPlayerObject)
        {
            playerObject = updatedPlayerObject;
        }

        private void initializeGameworld(ContentHolder contentHolder)
        {
            playerObject = new Player(contentHolder.texturePlayer, 0, 0, Vector2.Zero, 100, 100);
            rock = new Collidable(contentHolder.textureRock01, 200, 350, Vector2.Zero);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            playerObject.Draw(spriteBatch);
            rock.Draw(spriteBatch);
        }
    }
}
