using System.Collections.Generic;
using System.Windows;
using PolygonVisitor.Visitors;

namespace PolygonVisitor.Polygons
{
    public abstract class Polygon
    {
        public abstract int VerticesCount { get; }
        public List<Point> Vertices;
        public abstract void Accept(IVisitor visitor);

        public Polygon(List<Point> vertices)
        {
            Vertices = vertices;
        }
    }
}