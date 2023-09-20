using Shapes;
using System;

namespace HomeWork2_2.Data
{
    public class ShapeRepository : IShapeRepository
    {
        private readonly string _path;
        private readonly FormatConverter _converter;
        public ShapeRepository(string path)
        {
            _path = path;
            _converter = new();
        }

        public List<Shape> GetAllShapes()
        {
            List<Shape> shapes = new();
            if (File.Exists(_path))
            {
                string json = File.ReadAllText(_path);
                shapes = _converter.FromJson(json);
            }
            return shapes;
        }

        public void SaveAllShapes(List<Shape> shapes)
        {
            string json = _converter.ToJson(shapes);
            File.WriteAllText(_path, json);
        }
    }
}
