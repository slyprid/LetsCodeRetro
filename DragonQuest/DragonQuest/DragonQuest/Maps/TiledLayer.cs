using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DragonQuest.Maps
{
    public class TiledLayer
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("width")]
        public int Width { get; set; }

        [XmlAttribute("height")]
        public int Height { get; set; }

        [XmlAttribute("visible")]
        public bool Visible { get; set; }

        [XmlElement("data")]
        public TiledLayerData Tiles { get; set; }

        public TiledLayer()
        {
            Visible = true;
        }

        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, TiledTileset tileset)
        {
            
        }
    }
}