namespace Shapes
{
    public class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public virtual string ShowName()
        {
           return $"Фігура: {Name}";
        }
        public virtual string Display()
        {
            return $"Візуальне відображення: {Name}";
        }
    }
}