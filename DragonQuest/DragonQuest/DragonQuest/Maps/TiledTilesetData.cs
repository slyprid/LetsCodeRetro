using System.Xml.Serialization;

namespace DragonQuest.Maps
{
    [XmlRoot("tileset")]
    public class TiledTilesetData
    {
        public string Name { get; set; }
    }
}