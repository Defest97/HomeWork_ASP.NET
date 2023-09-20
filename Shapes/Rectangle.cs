using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public double Width { get; set; } // Ширина прямокутника
        public double Height { get; set; } // Висота прямокутника

        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
        }

        public override string Display()
        {
            return $"Фігура: {Name}, Ширина: {Width}, Висота: {Height}";
        }
    }
}
