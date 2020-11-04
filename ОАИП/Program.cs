using System;

namespace ОАИП
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кокос", new DateTime(2015, 02, 10));
            Console.WriteLine($"Коту по имени {cat.Name} уже {cat.GetAge()} лет");
            cat.HungryStatus = 150;
            Console.ReadLine();
        }
    }
}
