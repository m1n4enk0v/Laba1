using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z8
{
    public class PostalItem
    {
        public string Index { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Building { get; set; }
        public string Apartment { get; set; }
        public string Message { get; set; }
        public bool Valid()
        {
            return !string.IsNullOrEmpty(Index) &&
                   !string.IsNullOrEmpty(City) &&
                   !string.IsNullOrEmpty(Street) &&
                   !string.IsNullOrEmpty(House) &&
                   !string.IsNullOrEmpty(Building) &&
                   !string.IsNullOrEmpty(Apartment) &&
                   !string.IsNullOrEmpty(Message);
        }

        public string Address
        {
            get
            {
                return $"{Index}, {City}, {Street}, д.{House}, к.{Building}, кв.{Apartment}";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PostalItem item = new PostalItem
            {
                Index = "123456",
                City = "Москва",
                Street = "Ленина",
                House = "10",
                Building = "1",
                Apartment = "20",
                Message = "Здравствуйте! Ваш заказ готов."
            };
            if (item.Valid())
            {
                Console.WriteLine("Почтовое отправление валидно.");
                Console.WriteLine($"Адрес: {item.Address}");
                Console.WriteLine($"Сообщение: {item.Message}");
            }
            else
            {
                Console.WriteLine("Почтовое отправление не валидно.");
            }
        }
    }
}
