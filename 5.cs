using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    public class Smartphone
    {
        public string Model { get; set; }
        public double Cpu { get; set; }
        public int Ram { get; set; }
        public int Memory { get; set; }
        public string OperatingSystem { get; set; }
        public double Weight { get; set; }

        public string Info
        {
            get
            {
                return $"Модель: {Model}, Тактовая частота: {Cpu} GHz, Оперативная память: {Ram} ГБ, Постоянная память: {Memory} ГБ, Операционная система: {OperatingSystem}, Масса: {Weight} кг";
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone()
            {
                Model = "Apple iPhone 15 Pro Max",
                Cpu = 3.78,
                Ram = 8,
                Memory = 256,
                OperatingSystem = "iOS17",
                Weight = 0.221 
            };
            Console.WriteLine(smartphone.Info);
        }
    }
}
