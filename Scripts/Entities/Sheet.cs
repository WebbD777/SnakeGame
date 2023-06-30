using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Data.Common;


namespace SnakeGame.Scripts.Entities
{
    internal class Sheet
    {
        private Texture2D _texture;
        private int _row;
        private int _col;
        private int currentFrame;
        private int totalFrames;

        int width;
        int height;
        int rowBody;
        private int colBody;
        int rowHead;
        private int colHead;
        private int rowPellet;
        private int colPellet;

        private List<Microsoft.Xna.Framework.Rectangle> arrSheet;

        public Vector2 enemyBounds = new Vector2(300, 150);

        public Sheet(Texture2D texture, int row, int coloumn) { 
            _texture = texture;
            _row = row;
            _col = coloumn;
        }

        public void LoadContent() {

             width = _texture.Width / _col;
             height = _texture.Height / _row;

             rowBody = 0 / _col;
             colBody = 0 % _col; //Head

             rowHead = 1 / _col;
             colHead = 1 % _col; //Body

             rowPellet = 2 / _col;
             colPellet = 2 % _col; //Pellet

        }

        public void Update(SpriteBatch spriteBatch, GraphicsDevice graphics) 
        { 
            


        }

        public void Draw(SpriteBatch spriteBatch) {

            Rectangle sourceRectangle = new Rectangle(0, 0, 0, 0);
            Rectangle destinationRectangle = new Rectangle(0, 0, 0, 0);

            sourceRectangle.X = width * colHead; sourceRectangle.Y = height * rowHead; sourceRectangle.Width = width; sourceRectangle.Height = height;
            destinationRectangle.X = (int)enemyBounds.X; destinationRectangle.Y = (int)enemyBounds.Y; destinationRectangle.Width = width; destinationRectangle.Height = height;

            spriteBatch.Begin();

            spriteBatch.Draw(_texture, destinationRectangle, sourceRectangle, Color.White);

            spriteBatch.End();


        }
    }
}
