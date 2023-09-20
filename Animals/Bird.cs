using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Bird : Animal
    {
        public string Species { get; set; }

        public Bird(string name, int age, string species) : base(name, age)
        {
            Species = species;
        }

        public override string MakeSound()
        {
            return "Птах співає";
        }
    }
}
