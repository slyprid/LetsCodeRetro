using DragonQuest.Maps;
using Microsoft.Xna.Framework;

namespace DragonQuest.Scenes
{
    public class ThroneRoomScene
        : Scene
    {
        public TiledMap Map { get; set; }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void LoadContent()
        {
            Map = TiledMapLoader.Load(".\\Content\\maps\\throneroom.tmx", Content);

            IsLoaded = true;
        }

        public override void Update(GameTime gameTime)
        {
            if (!IsInitialized)
            {
                Initialize();
            }

            if (!IsLoaded)
            {
                LoadContent();
            }
        }

        public override void Draw(GameTime gameTime)
        {
            if (!IsInitialized || !IsLoaded) return;
        }
    }
}