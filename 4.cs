using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    public class Laptop
    {
        public string Model { get; set; }
        public double Cpu { get; set; }
        public int Ram { get; set; }
        public int Sdd { get; set; }
        public double Weight { get; set; }

        public string Info
        {
            get
            {
                return $"Модель: {Model}, Тактовая частота: {Cpu} GHz, Оперативная память: {Ram} ГБ, Жесткий диск: {Sdd} ГБ, Масса: {Weight} кг";
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Laptop laptop = new Laptop()
            {
                Model = "MSI Titan 18 HX",
                Cpu = 3.8,
                Ram = 32,
                Sdd = 3000,
                Weight = 3.6
            };
            Console.WriteLine(laptop.Info);
        }
    }
}
