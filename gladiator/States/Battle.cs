using gladiator.States.Setup;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace gladiator.States
{
    public class Battle : Game_State
    {
        private SpriteFont _font;

        public Battle(GraphicsDeviceManager _graphics, ContentManager _content)
      : base(_graphics, _content)
        {

        }
        public override void Initialize()
        {

        }

        public override void LoadContent(ContentManager _content)
        {

            // Setup the desktop

            //Load media
            _font = _content.Load<SpriteFont>("fonts/mainfont");

            // Add UI to the screen
        }

        public override void UnloadContent()
        {

        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.DrawString(_font, "You are in a fight now", new Vector2(100, 100), Color.Black);

            spriteBatch.End();
        }
    }
}
