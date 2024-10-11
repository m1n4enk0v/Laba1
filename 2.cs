using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    public class User
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public int Age { get; set; }
        public string FullName
        {
            get
            {
                return $"{Surname} {Name} {Otchestvo}";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User пользователь = new User
            {
                Surname = "Горенков",
                Name = "Олег",
                Otchestvo = "Алексеевич",
                Age = 52
            };
            Console.WriteLine($"ФИО: {пользователь.FullName}");
            Console.WriteLine($"Возраст: {пользователь.Age}");
        }
    }
}
