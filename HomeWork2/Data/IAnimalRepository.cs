using Animals;

namespace HomeWork2.Data
{
    public interface IAnimalRepository
    {
        List<Animal> GetAllAnimals();
        void SaveAllAnimals(List<Animal> animals);
    }
}
