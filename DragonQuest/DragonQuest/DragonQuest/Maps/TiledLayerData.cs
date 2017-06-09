using System.Xml.Serialization;

namespace DragonQuest.Maps
{
    public class TiledLayerData
    {
        [XmlAttribute("encoding")]
        public string Encoding { get; set; }

        [XmlText]
        public string TileData { get; set; }

        [XmlIgnore]
        public TiledTile[,] Tiles { get; set; }
    }
}