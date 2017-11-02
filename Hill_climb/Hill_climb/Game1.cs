using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace Hill_climb
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D hill;
        Texture2D Start_logo;
        Texture2D Car_2D_StartScreen;
        Texture2D cursor;
       
        int logo_y_posistion;
        int logo_car2d_x_posistion;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = true;
            
            

        }


        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graphics.PreferredBackBufferHeight = 768;
            graphics.PreferredBackBufferWidth = 1366;
            
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            logo_y_posistion = -50;
            logo_car2d_x_posistion = 768;
           // Create a new SpriteBatch, which can be used to draw textures.

            hill = Content.Load<Texture2D> ("Capture"); // not used
            Start_logo = Content.Load<Texture2D>("hill_climb_racing_2_logo");
            Car_2D_StartScreen = Content.Load<Texture2D>("car2d");
            cursor = Content.Load<Texture2D>("Cursor_icon_with_shadow");
            


            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if(logo_y_posistion < 384 - Start_logo.Height / 6)
            {
                
                logo_y_posistion += gameTime.ElapsedGameTime.Milliseconds/10;
            }
            if (logo_car2d_x_posistion >-100)
            {                
                logo_car2d_x_posistion -= gameTime.ElapsedGameTime.Milliseconds / 8;
            }
            if(logo_car2d_x_posistion == -100)
            {
                logo_car2d_x_posistion = 768;
            }
           


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();



            GraphicsDevice.Clear(Color.ForestGreen);
            
            spriteBatch.Draw(Start_logo, new Rectangle(720-Start_logo.Width/6 ,logo_y_posistion, Start_logo.Width/6, Start_logo.Height/6),Color.White);
            spriteBatch.Draw(Car_2D_StartScreen, new Rectangle(logo_car2d_x_posistion,400,Car_2D_StartScreen.Width/3,Car_2D_StartScreen.Height/3), Color.White);
            spriteBatch.Draw(cursor, new Vector2(Mouse.GetState().X, Mouse.GetState().Y),Color.White);
;           spriteBatch.End();
           

            base.Draw(gameTime);
        }
    }
}
