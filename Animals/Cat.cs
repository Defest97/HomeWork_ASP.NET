using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        public string Color { get; set; }

        public Cat(string name, int age, string color) : base(name, age)
        {
            Color = color;
        }

        public override string MakeSound()
        {
            return "Кіт муркоче";
        }
    }

}
