using System;

namespace _01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            int duration = int.Parse(Console.ReadLine());

            double ad = duration * 20 / 100;
            double time = seasons * episodes * (duration + ad) + seasons * 10;
            Console.WriteLine($"Total time needed to watch the {name} series is {Math.Floor(time)} minutes.");
        }
    }
}
