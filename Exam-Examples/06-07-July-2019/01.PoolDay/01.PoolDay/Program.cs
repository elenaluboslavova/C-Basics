using System;

namespace _01.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double fee = double.Parse(Console.ReadLine());
            double sunbedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double umbrella = Math.Ceiling(people*1.0 / 2);
            double sunbed = Math.Ceiling(people*1.0 * 75 / 100);

            double sum = people * fee + umbrella * umbrellaPrice + sunbed * sunbedPrice;
            Console.WriteLine($"{sum:F2} lv.");
        }
    }
}
