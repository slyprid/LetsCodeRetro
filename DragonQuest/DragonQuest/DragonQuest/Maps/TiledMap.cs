using System.Collections.Generic;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DragonQuest.Maps
{
    [XmlRoot("map")]
    public class TiledMap
    {
        [XmlAttribute("version")]
        public string Version { get; set; }

        [XmlAttribute("orientation")]
        public string Orientation { get; set; }

        [XmlAttribute("renderorder")]
        public string RenderOrder { get; set; }

        [XmlAttribute("width")]
        public int Width { get; set; }

        [XmlAttribute("height")]
        public int Height { get; set; }

        [XmlAttribute("tilewidth")]
        public int TileWidth { get; set; }

        [XmlAttribute("tileheight")]
        public int TileHeight { get; set; }

        [XmlAttribute("nextobjectid")]
        public int NextObjectId { get; set; }

        [XmlElement("tileset")]
        public TiledTileset Tileset { get; set; }

        [XmlElement(ElementName = "layer", Type = typeof(TiledLayer))]
        public List<TiledLayer> Layer { get; set; }

        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            
        }

    }
}