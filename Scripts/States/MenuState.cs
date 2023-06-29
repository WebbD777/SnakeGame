using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SnakeGame.Scripts.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Scripts.States
{
    internal class MenuState : State
    {
        private Texture2D menuBackGroundTexture;

        private List<Button> _components;
        public MenuState(Game1 game, GraphicsDevice graphicsDevice, ContentManager contentManager) : base(game, graphicsDevice, contentManager)
        {
            var buttonTexture = _content.Load<Texture2D>("Controls/Button1");
            var buttonFont = _content.Load<SpriteFont>("Fonts/butFont");
            var menuBackGroundTexture = _content.Load<Texture2D>("Environment/stars");

            var newGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(100, 100),
                Text = "New Game",
            };
            newGameButton.Click += NewGameButton_Click;

            var loadGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(100, 200),
                Text = "Load Game",
            };
            loadGameButton.Click += LoadGameButton_Click;

            var quitGameButton = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(100, 300),
                Text = "Quit Game",
            };
            quitGameButton.Click += QuitGameButton_Click;

            _components = new List<Button>()
            {
                newGameButton,
                loadGameButton, 
                quitGameButton
            };
        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
           _game.Exit();
        }

        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            _game.ChangeState(new GameState(_game, _graphicsDevice, _content));
        }


        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            //Draws all the buttons in list
            foreach (var button in _components)
            {
                button.Draw(gameTime, spriteBatch);
            }
            spriteBatch.End();
        }

        public override void LoadContent()
        {
            throw new NotImplementedException();
        }

        public override void PostUpdate(GameTime gameTime)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Post update");
        }

 

        public override void Update(GameTime gameTime)
        {
            foreach (var button in _components)
            {
                button.Update(gameTime);
            }
        }

        public override void NewGameButton_Click(object sender, EventHandler e)
        {
            throw new NotImplementedException();
        }

        public override void LoadGameButton_Click(object sender, EventHandler e)
        {
            throw new NotImplementedException();
        }

        public override void QuitGameButton_Click(object sender, EventHandler e)
        {
            throw new NotImplementedException();
        }
    }
}
