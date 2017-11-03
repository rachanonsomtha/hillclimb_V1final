using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hill_climb.Class;
using Microsoft.Xna.Framework.Media;

namespace Hill_climb

{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 :Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        Car player;

       
        
        
        int logo_y_posistion = -50;
        int logo_car2d_x_posistion = 768;
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
            int logo_y_posistion = -50;
            int logo_car2d_x_posistion = 768;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
           
           // Create a new SpriteBatch, which can be used to draw textures.

          
            player = new Car(Content.Load<Texture2D>("car2d"),new Vector2(50,50));
          

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

            /*if (logo_y_posistion < 384 - Start_logo.Height / 6)
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
            */

            player.Update(gameTime);

           


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



            GraphicsDevice.Clear(Color.LawnGreen);
            player.Draw(spriteBatch);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
