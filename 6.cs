using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z6
{
    public class Rectangle
    {
        public (double X, double Y) TopLeft { get; set; }
        public (double X, double Y) BottomRight { get; set; }

        public double CalculatePerimeter()
        {
            double width = BottomRight.X - TopLeft.X;
            double height = TopLeft.Y - BottomRight.Y;
            return 2 * (width + height);
        }

        public double CalculateArea()
        {
            double width = BottomRight.X - TopLeft.X;
            double height = TopLeft.Y - BottomRight.Y;
            return width * height;
        }
        public string Info
        {
            get
            {
                return $"Левый верхний угол: ({TopLeft.X}, {TopLeft.Y}), " +
                       $"Правый нижний угол: ({BottomRight.X}, {BottomRight.Y}), " +
                       $"Площадь: {CalculateArea()}, Периметр: {CalculatePerimeter()}";
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle()
            {
                TopLeft = (0, 5),
                BottomRight = (4, 0)
            };
            Console.WriteLine(rectangle.Info);
        }
    }
}
