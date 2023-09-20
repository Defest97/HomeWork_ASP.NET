using Shapes;

namespace HomeWork2_2.Data
{
    public interface IFormatConverter
    {
        string ToJson(List<Shape> shapes);
        List<Shape> FromJson(string json);
        string ToXML(List<Shape> shapes);
        List<Shape> FromXML(string xml);
    }
}
