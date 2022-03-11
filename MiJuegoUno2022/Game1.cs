using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiJuegoUno2022
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        byte red;
        byte green;
        byte blue;

        Texture2D spaceShip;
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

            red = 100;
            green = 20;
            blue = 250;
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            spaceShip = this.Content.Load<Texture2D>("SpaceShip");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            red++; //red = red + 1;
            green++;
            blue++;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //GraphicsDevice.Clear(new Color(red, green, blue));
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(spaceShip, new Vector2(300, 250), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
