using Animals;

namespace HomeWork2.Data
{
    public class AnimalRepository:IAnimalRepository
    {
        private readonly string _path;
        private readonly FormatConverter _converter;
        public AnimalRepository(string path)
        {
            _path = path;
            _converter = new();
        }

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals= new List<Animal>();
            if(File.Exists(_path))
            {
                string json=File.ReadAllText(_path);
                animals = _converter.FromJson(json);
            }
            return animals;
        }

        public void SaveAllAnimals(List<Animal> animals)
        {
            string json= _converter.ToJson(animals);
            File.WriteAllText(_path, json);
        }
    }
}
