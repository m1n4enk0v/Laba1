using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z7
{
    public class Triangle
    {
        public (double X, double Y) A { get; set; }
        public (double X, double Y) B { get; set; }
        public (double X, double Y) C { get; set; }

        private double GetLength((double X, double Y) point1, (double X, double Y) point2)
        {
            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }
        public double GetPerimeter()
        {
            double AB = GetLength(A, B);
            double BC = GetLength(B, C);
            double CA = GetLength(C, A);
            return AB + BC + CA;
        }

        public double GetArea()
        {
            return Math.Abs((A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y)) / 2.0);
        }
        public string Info
        {
            get
            {
                return $"Координаты: A({A.X}, {A.Y}), B({B.X}, {B.Y}), C({C.X}, {C.Y}), " +
                       $"Площадь: {GetArea():F2}, Периметр: {GetPerimeter():F2}";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle
            {
                A = (0, 0),
                B = (4, 0),
                C = (0, 3)
            };
            Console.WriteLine(triangle.Info);
        }
    }
}
