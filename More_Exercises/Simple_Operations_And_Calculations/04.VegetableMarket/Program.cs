using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double vegKg = double.Parse(Console.ReadLine());
            double fruitKg = double.Parse(Console.ReadLine());

            double veg = N * vegKg;
            double fruit = M * fruitKg;
            double sum = veg + fruit;
            Console.WriteLine($"{sum/1.94:F2}");
        }
    }
}
