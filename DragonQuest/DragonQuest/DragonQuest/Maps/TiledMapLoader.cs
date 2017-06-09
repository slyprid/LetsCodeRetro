using System.IO;
using DragonQuest.Utilities;
using Microsoft.Xna.Framework.Content;

namespace DragonQuest.Maps
{
    public static class TiledMapLoader
    {
        public static TiledMap Load(string filename, ContentManager content)
        {
            var xml = File.ReadAllText(filename);
            var map = xml.FromXmlString<TiledMap>();

            var tilesetSource = map.Tileset.Source;
            var tilesetPath = Path.Combine(Path.GetDirectoryName(filename), tilesetSource);
            var tilesetXml = File.ReadAllText(tilesetPath);
            var tileset = tilesetXml.FromXmlString<TiledTilesetData>();

            return map;
        }
    }
}