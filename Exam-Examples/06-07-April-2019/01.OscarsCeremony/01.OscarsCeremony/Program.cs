using System;

namespace _01.OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statuettes = rent - rent * 30 / 100;
            double catering = statuettes - statuettes * 15 / 100;
            double music = catering * 1 / 2;
            double sum = rent + statuettes + catering + music;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
