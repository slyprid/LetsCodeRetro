using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DragonQuest.Utilities
{
    public static class XmlHelper
    {
        public static string ToXmlString<T>(this T input)
        {
            string xml;

            using (var sw = new StringWriter())
            {
                using (var xw = XmlWriter.Create(sw))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(sw, input);
                    xml = sw.ToString();
                }
            }

            return xml;
        }

        public static T FromXmlString<T>(this string xml)
        {
            T output;

            using (var reader = new StringReader(xml))
            {
                var serializer = new XmlSerializer(typeof(T));
                output = (T) serializer.Deserialize(reader);
            }

            return output;
        }
    }
}