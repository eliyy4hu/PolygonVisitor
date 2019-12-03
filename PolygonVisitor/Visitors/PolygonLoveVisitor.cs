using System;
using PolygonVisitor.Polygons;

namespace PolygonVisitor.Visitors
{
    public class PolygonLoveVisitor : IVisitor
    {
        public void Visit(Triangle triangle)
        {
            Console.WriteLine("I love triangles!");
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine("I love rectangles!");
        }

        public void Visit(Rhombus rhombus)
        {
            Console.WriteLine("I love rhombuses!");
        }
    }
}