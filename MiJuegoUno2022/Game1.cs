using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiJuegoUno2022
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        bool fireballSwitch;

        Texture2D spaceShip;
        Texture2D fireball;

        Rectangle fireballRectangle;
        Rectangle spaceshipRectangle;

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

            fireballSwitch = false;
            fireballRectangle = new Rectangle(0, 0, 50, 50);
            spaceshipRectangle = new Rectangle(300, 250, 200, 200);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            spaceShip = this.Content.Load<Texture2D>("SpaceShip");
            fireball = this.Content.Load<Texture2D>("Fireball");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState keysState = Keyboard.GetState();

            // TODO: Add your update logic here
            //red++; //red = red + 1;
            //green++;
            //blue++;

            if(keysState.IsKeyDown(Keys.Left))
            {
                spaceshipRectangle.X -= 5;
            }
            
            else if (keysState.IsKeyDown(Keys.Right))
            {
                spaceshipRectangle.X += 5;
            }

            else if(keysState.IsKeyDown(Keys.Space))
            {
                fireballSwitch = true;
                fireballRectangle.X = spaceshipRectangle.X + (spaceshipRectangle.Width/2) -25;
                fireballRectangle.Y = spaceshipRectangle.Y +10;
            }

            if(fireballSwitch)
            {
                fireballRectangle.Y-=10;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //GraphicsDevice.Clear(new Color(red, green, blue));
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            if (fireballSwitch)
            {
                _spriteBatch.Draw(fireball, fireballRectangle, Color.White);
            }

            _spriteBatch.Draw(spaceShip, spaceshipRectangle, Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
