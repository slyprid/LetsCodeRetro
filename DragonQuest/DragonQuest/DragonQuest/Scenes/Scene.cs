using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DragonQuest.Scenes
{
    public abstract class Scene
    {
        public SpriteBatch SpriteBatch => DragonQuestGame.Instance.SpriteBatch;
        public ContentManager Content => DragonQuestGame.Instance.Content;
        public bool IsLoaded { get; set; }
        public bool IsInitialized { get; set; }
        //public InputManager Input { get; set; }

        protected Scene()
        {
            //Input = new InputManager();
        }

        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime);

        public virtual void LoadContent()
        {
            IsLoaded = true;
        }

        public virtual void Initialize()
        {
            IsInitialized = true;
        }
    }
}