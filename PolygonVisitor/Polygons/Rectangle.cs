using System.Collections.Generic;
using System.Windows;
using PolygonVisitor.Visitors;

namespace PolygonVisitor.Polygons
{
    public class Rectangle : Polygon
    {
        public override int VerticesCount => 4;

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public Rectangle(List<Point> vertices) : base(vertices)
        {
        }
    }
}