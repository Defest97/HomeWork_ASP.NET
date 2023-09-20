using Shapes;

namespace HomeWork2_2.Data
{
    public class ShapeService
    {
        private readonly IShapeRepository _shapeRepository;
        public ShapeService(IShapeRepository shapeRepository)
        {
            _shapeRepository = shapeRepository;
        }
        public List<Shape> GetAllShapes()
        {
            return _shapeRepository.GetAllShapes();
        }
        public void SaveAllShapes(List<Shape> shapes)
        {
            _shapeRepository.SaveAllShapes(shapes);
        }
        public Circle CreateCircle(string name, double radius)
        {
            return new Circle(name,radius);
        }
        public Rectangle CreateRectangle(string name, double width, double height)
        {
            return new Rectangle(name, width, height);
        } 
        public Triangle CreateTriangle(string name, double sideA, double sideB,double sideC)
        {
            return new Triangle(name, sideA, sideB, sideC);
        }

    }
}
