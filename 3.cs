using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    public class PersonalComputer
    {
        public string Model { get; set; }
        public double Cpu { get; set; }
        public int Ram { get; set; }
        public int Hdd { get; set; }
        public string Info
        {
            get
            {
                return $"Модель: {Model}, Тактовая частота: {Cpu} GHz, Оперативная память: {Ram} ГБ, Жесткий диск: {Hdd} ГБ";
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            PersonalComputer pc = new PersonalComputer()
            {
                Model = "Asus ROK",
                Cpu = 3.25,
                Ram = 16,
                Hdd = 512
            };
            Console.WriteLine(pc.Info);
        }
    }
}
