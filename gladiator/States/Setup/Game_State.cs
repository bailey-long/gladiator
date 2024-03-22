using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gladiator.States.Setup
{
    public abstract class Game_State : IGame_State
    {
		protected GraphicsDeviceManager _graphics;
        protected ContentManager _content;

        public Game_State(GraphicsDeviceManager graphics, ContentManager content) 
        {

			graphics = _graphics;
            content = _content;
        }
        public abstract void Initialize();
        public abstract void LoadContent(ContentManager content);
        public abstract void UnloadContent();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
