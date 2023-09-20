namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string MakeSound()
        {
            return "Тварина видає звук";
        }
        public virtual string ShowName()
        {
            return $"Назва тварини: {Name}";
        }
    }
}