using System;
using System.Collections.Generic;
using System.Windows;
using PolygonVisitor.Polygons;
using PolygonVisitor.Visitors;

namespace PoligonVisiter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var triangle = new Triangle(new List<Point>() {new Point(0, 0), new Point(5, 5), new Point(0, 5)});
            var rectangle = new Rectangle(new List<Point>()
                {new Point(0, 0), new Point(0, 5), new Point(5, 5), new Point(5, 0)});
            var rhombus =
                new Rhombus(new List<Point> {new Point(0, 1), new Point(2, 0), new Point(4, 1), new Point(2, 2)});
            var areaVisitor = new GetAreaVisitor();
            triangle.Accept(areaVisitor);
            Console.WriteLine(areaVisitor.Result);
            rectangle.Accept(areaVisitor);
            Console.WriteLine(areaVisitor.Result);
            rhombus.Accept(areaVisitor);
            Console.WriteLine(areaVisitor.Result);
            Console.WriteLine();
            var drawVisitor = new DrawingVisitor(new Point(5, 5));
            triangle.Accept(drawVisitor);
            rectangle.Accept(drawVisitor);
            rhombus.Accept(drawVisitor);
            var polygonLoveVisitor = new PolygonLoveVisitor();
            triangle.Accept(polygonLoveVisitor);
            rectangle.Accept(polygonLoveVisitor);
            rhombus.Accept(polygonLoveVisitor);
        }
    }
}