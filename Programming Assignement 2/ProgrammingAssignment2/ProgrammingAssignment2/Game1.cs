using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        const int WindowWidth = 800;
        const int WindowHeight = 600;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Declare variables for three sprites
        Texture2D sprite0; 
        Texture2D sprite1;
        Texture2D sprite2;

        // Declare variables for x and y speeds
        int xSpeed;
        int ySpeed;

        // used to handle generating random values
        Random rand = new Random();
        const int ChangeDelayTime = 1000;
        int elapsedTime = 0;

        // used to keep track of current sprite and location
        Texture2D currentSprite;
        Rectangle drawRectangle = new Rectangle();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = WindowWidth;
            graphics.PreferredBackBufferHeight = WindowHeight;
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

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load the sprite images here
            sprite0 = Content.Load<Texture2D>(@"graphics\sprite1");
            sprite1 = Content.Load<Texture2D>(@"graphics\sprite2");
            sprite2 = Content.Load<Texture2D>(@"graphics\sprite3");

            // Set the currentSprite variable to one of your sprite variables
            currentSprite = sprite1;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            elapsedTime += gameTime.ElapsedGameTime.Milliseconds;
            if (elapsedTime > ChangeDelayTime)
            {
                elapsedTime = 0;

                // Generate a random number 
                // between 0 and 2 inclusive using the rand field I provided
                int spriteNumber = rand.Next(0,3);

                // Change sprite0, sprite1, and sprite2
                //      to the three different names of your sprite variables
                if (spriteNumber == 0)
                {
                    currentSprite = sprite0;
                }
                else if (spriteNumber == 1)
                {
                    currentSprite = sprite1;
                }
                else if (spriteNumber == 2)
                {
                    currentSprite = sprite2;
                }

                // Set the drawRectangle.Width and drawRectangle.Height to match the width and height of currentSprite
                drawRectangle.Width = currentSprite.Width;
                drawRectangle.Height = currentSprite.Height;

                // Center the draw rectangle in the window. Note that the X and Y properties of the rectangle
                // are for the upper left corner of the rectangle, not the center of the rectangle
                drawRectangle.X = 400 - currentSprite.Width/2;
                drawRectangle.Y = 300 - currentSprite.Height/2;

                // Write code below to generate random numbers  between -4 and 4 inclusive for the x and y speed 
                // using the rand field I provided
                xSpeed = rand.Next(-4, 5);
                ySpeed = rand.Next(-4, 5);

            }

            // Move the drawRectangle by the x speed and the y speed
            drawRectangle.Offset(xSpeed, ySpeed);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // STUDENTS: draw current sprite here
            spriteBatch.Begin();

            spriteBatch.Draw(currentSprite, drawRectangle, Color.White);

            spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
