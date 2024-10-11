using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z9
{
    public class Circle
    {
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double Radius { get; set; }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public string Info
        {
            get
            {
                return $"Окружность с центром в ({CenterX}, {CenterY}) и радиусом {Radius}. " +
                       $"Длина окружности: {CalculateCircumference().ToString("F2")}. " +
                       $"Площадь: {CalculateArea().ToString("F2")}.";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle
            {
                CenterX = 0.0,
                CenterY = 0.0,
                Radius = 5.0
            };
            Console.WriteLine(circle.Info);
        }
    }
}
