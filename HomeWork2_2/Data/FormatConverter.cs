using Shapes;
using System.Text.Json;
using System.Xml.Serialization;

namespace HomeWork2_2.Data
{
    public class FormatConverter : IFormatConverter
    {
        public List<Shape> FromJson(string json)
        {
            return JsonSerializer.Deserialize<List<Shape>>(json);
        }

        public List<Shape> FromXML(string xml)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Shape>));
            using (StringReader sr = new StringReader(xml))
            {
                return (List<Shape>)xmlSerializer.Deserialize(sr);
            }
        }

        public string ToJson(List<Shape> shapes)
        {
            return JsonSerializer.Serialize(shapes);
        }

        public string ToXML(List<Shape> shapes)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Shape>));
            using (StringWriter sw = new StringWriter())
            {
                xmlSerializer.Serialize(sw, shapes);
                return sw.ToString();
            }
        }
    }
}
