using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Xml.Schema;

namespace Monogame_Topic_2___Scaling_and_Text_Lesson
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D circleTexture, rectangleTexture;

        Rectangle circleFaceRect, circleEye1Rect, circleEye2Rect, rectangleMouthRect;

        SpriteFont titleFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 600);
            circleFaceRect = new Rectangle(100, 0, 600, 600);
            circleEye1Rect = new Rectangle(250, 100, 50, 50);
            circleEye2Rect = new Rectangle(500, 100, 50, 50);
            rectangleMouthRect = new Rectangle(300, 400, 200, 50);

            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            titleFont = Content.Load<SpriteFont>("Title");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(circleTexture, circleFaceRect, Color.Yellow);
            _spriteBatch.Draw(circleTexture, circleEye1Rect, Color.Black);
            _spriteBatch.Draw(circleTexture, circleEye2Rect, Color.Black);
            _spriteBatch.Draw(rectangleTexture, rectangleMouthRect, Color.Black);
            _spriteBatch.DrawString(titleFont, "Test", new Vector2(10, 10), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
