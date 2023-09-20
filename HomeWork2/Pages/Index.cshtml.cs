using Animals;
using HomeWork2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AnimalService _animalService;
        public List<Animal>? animals;
        public Dog? dog;
        public Cat? cat;
        public Bird? bird;
        public IndexModel(ILogger<IndexModel> logger, AnimalService animalService)
        {
            _logger = logger;
            _animalService = animalService;
        }

        public void OnGet()
        {
             //dog = _animalService.CreateDog("Барсик", 3, "Дворняга");
             //cat = _animalService.CreateCat("Мурка", 2, "Сірого кольору");
             //bird = _animalService.CreateBird("Співун", 1, "Канарка");
             animals=_animalService.GetAllAnimals();
            var a = animals[0].Name;
        }
    }
}