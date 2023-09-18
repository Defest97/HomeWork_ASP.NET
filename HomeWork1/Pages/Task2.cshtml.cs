using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork1.Pages
{
    public class Task2Model : PageModel
    {
        public char RandomLetter { get; set; }
        public void OnGet()
        {
            Random rnd=new Random();
            RandomLetter=(char)rnd.Next(97,122);
        }
    }
}
