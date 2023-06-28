using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Scripts.Controls
{
    internal class Button : Component
    {
        private Texture2D _texture;
        private SpriteFont _font;
        private GraphicsDeviceManager _graphics;
        public Button(Texture2D texture, SpriteFont spriteFont, GraphicsDeviceManager graphics) { 
        
            _texture = texture;
            _font = spriteFont;
            _graphics = graphics;
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            // To get midpoint of screen
            int width = _graphics.PreferredBackBufferWidth;
            int height = _graphics.PreferredBackBufferHeight;
            Vector2 vecPos = new Vector2(width / 2, height / 2);

            spriteBatch.Draw(_texture, vecPos, Color.White);
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
