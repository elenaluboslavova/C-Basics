using System;

namespace _01.EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPriceKg = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int eggsCartoons = int.Parse(Console.ReadLine());
            int yeastPack = int.Parse(Console.ReadLine());

            double sugarPriceKg = flourPriceKg - flourPriceKg * 25 / 100;
            double eggsCartoonsPrice = flourPriceKg + flourPriceKg * 10 / 100;
            double yeastPackPrice = sugarPriceKg - sugarPriceKg * 80 / 100;
            double sum = flourPriceKg * flourKg + sugarPriceKg * sugarKg +
                eggsCartoonsPrice * eggsCartoons + yeastPackPrice * yeastPack;
            Console.WriteLine($"{sum*1.0:F2}");
        }
    }
}
