using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gladiator.States.Setup
{
    public class Game_State_Manager
    {
        private ContentManager _content;

		// Instance of the game state manager     
		private static Game_State_Manager _instance;

        // Stack for the screens     
        private Stack<Game_State> _screens = new Stack<Game_State>();

        public static Game_State_Manager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Game_State_Manager();
                }
                return _instance;
            }
        }

        // Sets the content manager
        public void SetContent(ContentManager content)
        {
            _content = content;
        }

        // Adds a new screen to the stack 
        public void AddScreen(Game_State screen)
        {
            try
            {
                // Add the screen to the stack
                _screens.Push(screen);
                // Initialize the screen
                _screens.Peek().Initialize();
                // Call the LoadContent on the screen
                if (_content != null)
                {
                    _screens.Peek().LoadContent(_content);
                }
            }
            catch (Exception ex)
            {
                // Log the exception
            }
        }

        // Removes the top screen from the stack
        public void RemoveScreen()
        {
            if (_screens.Count > 0)
            {
                try
                {
                    var screen = _screens.Peek();
                    _screens.Pop();
                }
                catch (Exception ex)
                {
                    // Log the exception
                }
            }
        }

        // Clears all the screen from the list
        public void ClearScreens()
        {
            while (_screens.Count > 0)
            {
                _screens.Pop();
            }
        }

        // Removes all screens from the stack and adds a new one 
        public void ChangeScreen(Game_State screen)
        {
            try
            {
                ClearScreens();
                AddScreen(screen);
            }
            catch (Exception ex)
            {
                // Log the exception
            }
        }

        public void Update(GameTime gameTime)
        {
            try
            {
                if (_screens.Count > 0)
                {
                    _screens.Peek().Update(gameTime);
                }
            }
            catch (Exception ex)
            {

            }
        }

        // Renders the top screen.
        public void Draw(SpriteBatch spriteBatch)
        {
           // try
           // {
                if (_screens.Count > 0)
                {
                    _screens.Peek().Draw(spriteBatch);
                }
           // }
           // catch (Exception ex)
           // {
                //_logger.Error(ex);
            //}
        }

        // Unloads the content from the screen
        public void UnloadContent()
        {
            foreach (Game_State state in _screens)
            {
                state.UnloadContent();
            }
        }
    }
}
