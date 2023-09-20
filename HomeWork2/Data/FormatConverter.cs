using Animals;
using System.Text.Json;
using System.Xml.Serialization;

namespace HomeWork2.Data
{
    public class FormatConverter:IFormatConverter
    {
        public string ToJson(List<Animal> animals)
        {
            return JsonSerializer.Serialize(animals);
        }
        public List<Animal> FromJson(string json)
        {
            return JsonSerializer.Deserialize<List<Animal>>(json);
        }
        public string ToXML(List<Animal> animals)
        {
            var xmlSerializer=new XmlSerializer(typeof(List<Animal>));
            using(StringWriter sw=new StringWriter()) 
            {
                xmlSerializer.Serialize(sw, animals);
                return sw.ToString();
            }
        }
        public List<Animal> FromXML(string xml)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Animal>));
            using (StringReader sr = new StringReader(xml))
            {
                return (List<Animal>)xmlSerializer.Deserialize(sr);
            }
        }
    }
}
