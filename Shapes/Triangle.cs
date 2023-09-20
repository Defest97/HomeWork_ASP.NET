using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public double SideA { get; set; } // Сторона A
        public double SideB { get; set; } // Сторона B
        public double SideC { get; set; } // Сторона C

        public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override string Display()
        {
            return $"Фігура: {Name}, Сторона A: {SideA}, Сторона B: {SideB}, Сторона C: {SideC}")
        }
    }
}
