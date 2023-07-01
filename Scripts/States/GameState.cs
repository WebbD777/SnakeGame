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
        bool loadedBol; // To stop reloading snake sprite sheet
        private List<Rectangle> sheetArr;
        private Texture2D sheetSprite;
        public GameState(Game1 game, GraphicsDevice graphicsDevice, ContentManager contentManager) : base(game, graphicsDevice, contentManager)
        {
            loadedBol = false;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            
            if (loadedBol == false) // To stop reloading snake sprite sheet
                LoadContent();

            // 
            sheetArr = sheet.getListSprite();
            Rectangle destRec = sheetArr[3];

            spriteBatch.Begin();

            spriteBatch.Draw(sheetSprite, new Rectangle(destRec.X, destRec.Y, destRec.Width, destRec.Height), sheetArr[0], Color.White);
            spriteBatch.Draw(sheetSprite, new Rectangle(destRec.X + 33, destRec.Y, destRec.Width, destRec.Height), sheetArr[1], Color.White);

            spriteBatch.End();

            //  sheet.Draw(spriteBatch);
        }

        public override void LoadContent()
        {
            //    throw new NotImplementedException();

             // To stop reloading snake sprite sheet
           // {
                sheetSprite = _content.Load<Texture2D>("Sprites/snake");
                sheet = new Sheet(sheetSprite, 1, 3);
                sheet.LoadContent();

                loadedBol = true;
          //  }


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
