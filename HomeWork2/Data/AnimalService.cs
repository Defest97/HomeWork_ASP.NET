using HomeWork2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class AnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public List<Animal> GetAllAnimals()
        {
            return _animalRepository.GetAllAnimals();
        }

        public void SaveAllAnimals(List<Animal> animals)
        {
            _animalRepository.SaveAllAnimals(animals);
        }
        public Dog CreateDog(string name, int age, string breed)
        {
            return new Dog(name, age, breed);
        }

        public Cat CreateCat(string name, int age, string color)
        {
            return new Cat(name, age, color);
        }

        public Bird CreateBird(string name, int age, string species)
        {
            return new Bird(name, age, species);
        }
    }
}
