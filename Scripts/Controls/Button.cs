using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Scripts.Controls
{
    internal class Button : Component
    {
        #region Fields
        private Texture2D _texture;
        private SpriteFont _font;
     //   private GraphicsDeviceManager _graphics;

        private int width;
        private int height;

        private Color _shade;

        public event EventHandler Click;
        private MouseState _lastMouseState;
        #endregion

        #region Properties

        public bool Clicked { get; private set; }
        public Color Pencolour { get; private set; }
        public Vector2 Position { get;  set; }

        public Rectangle Rectangle 
        { get 
            { 
                return new Rectangle ((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height);
            } 
        }

        public String Text { get;  set; }

        #endregion

        #region Methods
        public Button(Texture2D texture, SpriteFont spriteFont){ //), GraphicsDeviceManager graphics) { 
        
            _texture = texture;
            _font = spriteFont;
        //    _graphics = graphics;

            Pencolour = Color.Black;
            _shade = Color.White;
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            
            //Vector2 vecPos = new Vector2(width / 2, height / 2);
           // Vector2 vecPos = new Vector2(Position.X, Position.Y);

            //Draws the buttons
            spriteBatch.Draw(_texture, Rectangle, _shade);

            //Draws text on Buttons
            if (string.IsNullOrEmpty(Text) == false)
            {
                var x = (Rectangle.X + (Rectangle.Width / 2)) - (_font.MeasureString(Text).X / 2);
                var y = (Rectangle.Y + (Rectangle.Height / 2)) - (_font.MeasureString(Text).Y / 2);

                spriteBatch.DrawString(_font, Text, new Vector2(x, y), Pencolour);
            }
        }

        public override void Update(GameTime gameTime)
        {
            // To get midpoint of screen
           //  width = _graphics.PreferredBackBufferWidth;
         //    height = _graphics.PreferredBackBufferHeight;

            //Get mouse state
            MouseState ms = Mouse.GetState();
            //Mouse rectangle
            Rectangle cursorRec = new Rectangle(ms.Position.X, ms.Position.Y, 1, 1);

            //If cursor intersects button
            if (cursorRec.Intersects(Rectangle))
            {
                _shade = Color.Gray;

                //Action when button is pressed
                if (ms.LeftButton == ButtonState.Pressed && _lastMouseState.LeftButton == ButtonState.Released)
                {
                    //Action changes window
                    _shade = Color.Red;
                    Click?.Invoke(this, new EventArgs());
                }
            }
            else
            {
                _shade = Color.White;
            }

            //Saves last Mouse State
            _lastMouseState = ms;
        }

        #endregion
    }
}
