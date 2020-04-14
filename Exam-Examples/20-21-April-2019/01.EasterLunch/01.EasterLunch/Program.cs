using System;

namespace _01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterbread = int.Parse(Console.ReadLine());
            int eggCartoon = int.Parse(Console.ReadLine());
            int cookiesKg = int.Parse(Console.ReadLine());

            double sum = easterbread * 3.20 + eggCartoon * 4.35 +
                cookiesKg * 5.40 + eggCartoon * 12 * 0.15;
            Console.WriteLine($"{sum*1.0:F2}");
        }
    }
}
