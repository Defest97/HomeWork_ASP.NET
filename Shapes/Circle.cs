using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; } // Радіус кола

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override string Display()
        {
            return $"Фігура: {Name}, Радіус: {Radius}";
        }
    }
}
