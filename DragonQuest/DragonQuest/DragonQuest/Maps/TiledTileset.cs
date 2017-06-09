using System.Xml.Serialization;
using Microsoft.Xna.Framework.Graphics;

namespace DragonQuest.Maps
{
    public class TiledTileset
    {
        [XmlAttribute("firstgid")]
        public int FirstGId { get; set; }

        [XmlAttribute("source")]
        public string Source { get; set; }

        [XmlIgnore]
        public Texture2D Texture { get; set; }

        [XmlIgnore]
        public string Name { get; set; }

        [XmlIgnore]
        public int TileWidth { get; set; }

        [XmlIgnore]
        public int TileHeight { get; set; }

        [XmlIgnore]
        public int Columns { get; set; }

        [XmlIgnore]
        public int Rows { get; set; }
    }
}