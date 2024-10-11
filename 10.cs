using System;
using System.Collections.Generic;

namespace Z10
{
    public class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public class Line
    {
        public Point Start;
        public Point End;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public double GetLength()
        {
            double dx = End.X - Start.X;
            double dy = End.Y - Start.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }

    public class Polyline
    {
        private List<Point> points;

        public Polyline()
        {
            points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            points.Add(point);
        }

        public double GetLength()
        {
            double length = 0;
            for (int i = 0; i < points.Count - 1; i++)
            {
                Line line = new Line(points[i], points[i + 1]);
                length += line.GetLength();
            }
            return length;
        }

        public int PointCount
        {
            get { return points.Count; }
        }

        public int SegmentCount
        {
            get { return points.Count - 1; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Polyline polyline = new Polyline();
            polyline.AddPoint(new Point(0, 0));
            polyline.AddPoint(new Point(3, 4));
            polyline.AddPoint(new Point(6, 0));

            Console.WriteLine("Длина ломаной линии: " + polyline.GetLength());
            Console.WriteLine("Количество точек: " + polyline.PointCount);
            Console.WriteLine("Количество отрезков: " + polyline.SegmentCount);
        }
    }
}
