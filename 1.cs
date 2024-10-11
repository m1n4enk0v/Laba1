using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    public class Point
    {

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public void MoveBy(double dx, double dy, double dz)
        {
            X += dx;
            Y += dy;
            Z += dz;
        }


        public void PrintCoordinates()
        {
            Console.WriteLine($"Точка находится в ({X}, {Y}, {Z})");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            Point point = new Point(1.0, 2.0, 3.0);
            point.PrintCoordinates();
            point.MoveBy(1.0, -1.0, 2.0);
            point.PrintCoordinates();
        }
    }
}
