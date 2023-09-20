using Shapes;

namespace HomeWork2_2.Data
{
    public interface IShapeRepository
    {
        List<Shape> GetAllShapes();
        void SaveAllShapes(List<Shape> shapes);
    }
}
