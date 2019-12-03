using System.Collections.Generic;
using System.Windows;
using PolygonVisitor.Visitors;

namespace PolygonVisitor.Polygons
{
    public class Triangle : Polygon
    {
        public override int VerticesCount => 3;

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public Triangle(List<Point> vertices) : base(vertices)
        {
        }
    }
}