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
    public class Main_Menu : Game_State
    {
        private SpriteFont _font;
        private string _title = "the game works";
        private int _score = 0;
        public Main_Menu(GraphicsDeviceManager _graphics, ContentManager _content)
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
            _score++;
            if(_score >= 200)
            {
                //Change screen
                Game_State_Manager.Instance.RemoveScreen();
                Game_State_Manager.Instance.ChangeScreen(new Battle(_graphics, _content));
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.DrawString(_font, "Gladiator Game Awesome POggers", new Vector2(100, 100), Color.Black);
            spriteBatch.DrawString(_font, "score: " + _score, new Vector2(100, 10), Color.Black);

            spriteBatch.End();
        }
    }
}
