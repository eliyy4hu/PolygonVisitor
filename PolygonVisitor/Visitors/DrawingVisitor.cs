using System;
using System.Linq;
using System.Windows;
using PolygonVisitor.Polygons;

namespace PolygonVisitor.Visitors
{
    public class DrawingVisitor : IVisitor
    {
        private Point shiftVector;

        public DrawingVisitor(Point shiftVector)
        {
            this.shiftVector = shiftVector;
        }

        public void Visit(Triangle triangle)
        {
            var points = triangle.Vertices.Select(x => new Point(x.X + shiftVector.X, x.Y + shiftVector.Y)).ToList();
            points.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
        }

        public void Visit(Rectangle rectangle)
        {
            var points = rectangle.Vertices.Select(x => new Point(x.X + shiftVector.X, x.Y + shiftVector.Y)).ToList();
            points.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
        }

        public void Visit(Rhombus rhombus)
        {
            var points = rhombus.Vertices.Select(x => new Point(x.X + shiftVector.X, x.Y + shiftVector.Y)).ToList();
            points.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
        }
    }
}