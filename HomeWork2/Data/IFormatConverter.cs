using Animals;

namespace HomeWork2.Data
{
    public interface IFormatConverter
    {
        string ToJson(List<Animal> animals);
        List<Animal> FromJson(string json);
        string ToXML(List<Animal> animals);
        List<Animal> FromXML(string xml);
    }
}
