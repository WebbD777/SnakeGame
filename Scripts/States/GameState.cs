using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SnakeGame.Scripts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Scripts.States
{
    internal class GameState : State
    {
        private Sheet sheet;
        public GameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager contentManager) : base(game, graphicsDevice, contentManager)
        {
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            // throw new NotImplementedException();
            var sheetSprite = _content.Load<Texture2D>("Sprites/snake");
            sheet = new Sheet(sheetSprite, 1, 3);
            sheet.LoadContent();

            sheet.Draw(spriteBatch);
        }

        public override void LoadContent()
        {
            //    throw new NotImplementedException();
            

            
        }

        public override void LoadGameButton_Click(object sender, EventHandler e)
        {
        //    throw new NotImplementedException();
        }

        public override void NewGameButton_Click(object sender, EventHandler e)
        {
      //      throw new NotImplementedException();
        }

        public override void PostUpdate(GameTime gameTime)
        {
         //   throw new NotImplementedException();
        }

        public override void QuitGameButton_Click(object sender, EventHandler e)
        {
      //      throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            //throw new NotImplementedException();
        }
    }
}
