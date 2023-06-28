using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Scripts.States
{
    public abstract class State
    {
        #region Fileds

        protected ContentManager _content;
        protected GraphicsDevice _graphicsDevice;
        protected Game1 _game;

        #endregion

        #region Methods

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        public abstract void PostUpdate(GameTime gameTime);

        public State(Game1 game, GraphicsDevice graphicsDevice, ContentManager contentManager)
        {
            _game = game;
            _content = contentManager;
            _graphicsDevice = graphicsDevice;
        }

        public abstract void Update(GameTime gameTime);

        public abstract void LoadContent();

        public abstract void NewGameButton_Click(object sender, EventHandler e);

        public abstract void LoadGameButton_Click(object sender, EventHandler e);

        public abstract void QuitGameButton_Click(object sender, EventHandler e);


        #endregion

    }
}
