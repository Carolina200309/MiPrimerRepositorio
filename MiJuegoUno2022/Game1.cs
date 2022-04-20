using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections;
using System.Collections.Generic;

namespace MiJuegoUno2022
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Player spaceShip;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            //_graphics.IsFullScreen = true;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            spaceShip = new Player();


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            spaceShip.LoadContent(this.Content);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState myKeyboard = Keyboard.GetState();

            // TODO: Add your update logic here

            if (myKeyboard.IsKeyDown(Keys.Left))
            {
                spaceShip.Move(false);
            }
            else if (myKeyboard.IsKeyDown(Keys.Right))
            {
                spaceShip.Move(true);
            }
            else if (myKeyboard.IsKeyDown(Keys.Space))
            {
                spaceShip.Shoot(this.Content, spaceShip.Location);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //GraphicsDevice.Clear(new Color(red,green,blue));
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            spaceShip.Draw(this._spriteBatch, Color.White);


            _spriteBatch.End();

            base.Draw(gameTime);
        }

    }
}