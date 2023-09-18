using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork1.Pages
{
    public class Task4Model : PageModel
    {
        public List<Restaurant> restaurants { get; set; }
        public void OnGet()
        {
            restaurants = new List<Restaurant>();
            for (int i = 0; i < 5; i++) 
            {
                restaurants.Add(new Restaurant { Name=$"NameTest{i+1}", Menu=$"MenuTest{i+1}", Location=$"LocationTest{i+1}"});
            }
        }
    }

}
