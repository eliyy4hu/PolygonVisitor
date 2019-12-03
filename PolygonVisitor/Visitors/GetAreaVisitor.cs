using System;
using System.Windows;
using PolygonVisitor.Polygons;

namespace PolygonVisitor.Visitors
{
    public class GetAreaVisitor : IVisitor
    {
        public double? Result;

        private double GetDistance(Point a, Point b)
        {
            return Point.Subtract(b, a).Length;
        }

        public void Visit(Triangle triangle)
        {
            var a = triangle.Vertices[0];
            var b = triangle.Vertices[1];
            var c = triangle.Vertices[2];
            var ab = GetDistance(a, b);
            var bc = GetDistance(b, c);
            var ca = GetDistance(c, a);
            var p = (ab + bc + ca) / 2;
            var square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
            Result = square;
        }

        public void Visit(Rectangle rectangle)
        {
            var a = rectangle.Vertices[0];
            var b = rectangle.Vertices[1];
            var c = rectangle.Vertices[2];
            var ab = GetDistance(a, b);
            var bc = GetDistance(b, c);
            var square = ab * bc;
            Result = square;
        }

        public void Visit(Rhombus rhombus)
        {
            var a = rhombus.Vertices[0];
            var b = rhombus.Vertices[1];
            var c = rhombus.Vertices[2];
            var d = rhombus.Vertices[3];
            var ac = GetDistance(a, c);
            var bd = GetDistance(b, d);
            var square = 1.0 / 2 * ac * bd;
            Result = square;
        }
    }
}