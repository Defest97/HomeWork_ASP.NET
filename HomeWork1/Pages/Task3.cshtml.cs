using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork1.Pages
{
    public class Task3Model : PageModel
    {
        public Restaurant restaurant { get; set; }
        public void OnGet()
        {
            restaurant=new Restaurant();
            restaurant.Name = "NameTest";
            restaurant.Menu = "MenuTest";
            restaurant.Location = "LocationTest";
        }
    }
    public class Restaurant
    {
        public string Name { get; set; }
        public string Menu { get; set; }
        public string Location { get; set; }
    }
}
