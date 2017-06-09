using DragonQuest.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DragonQuest
{
    public class DragonQuestGame 
        : Game
    {
        #region Properties / Fields

        private readonly GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public static DragonQuestGame Instance { get; private set; }
        public SpriteBatch SpriteBatch => _spriteBatch;

        public Scene CurrentScene { get; set; }
        public GameState CurrentState { get; set; }
        
        #endregion

        #region Initialization 

        public DragonQuestGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Window.Title = "Dragon Quest";
            _graphics.PreferredBackBufferWidth = 1024;
            _graphics.PreferredBackBufferHeight = 960;
            _graphics.ApplyChanges();

            Instance = this;
        }

        protected override void Initialize()
        {
            base.Initialize();

            CurrentState = new GameState();
            CurrentScene = new ThroneRoomScene();
        }

        #endregion

        #region Content

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
            
        }

        #endregion

        #region Update

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            CurrentScene?.Update(gameTime);

            base.Update(gameTime);
        }

        #endregion

        #region Rendering

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            CurrentScene?.Draw(gameTime);

            base.Draw(gameTime);
        }

        #endregion
    }
}