using PolygonVisitor.Polygons;

namespace PolygonVisitor.Visitors
{
    public interface IVisitor
    {
        void Visit(Triangle triangle);
        void Visit(Rectangle rectangle);
        void Visit(Rhombus rhombus);
    }
}