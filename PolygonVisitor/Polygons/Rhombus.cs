using System.Collections.Generic;
using System.Windows;
using PolygonVisitor.Visitors;

namespace PolygonVisitor.Polygons
{
    public class Rhombus : Polygon
    {
        public override int VerticesCount => 4;

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public Rhombus(List<Point> vertices) : base(vertices)
        {
        }
    }
}