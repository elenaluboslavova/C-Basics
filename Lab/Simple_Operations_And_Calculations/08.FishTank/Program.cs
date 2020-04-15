using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int volume = length * width * heigth;
            double volumeInLiters = volume * 0.001;
            double numberPercent = percent * 0.01;
            double freeSpace = volumeInLiters * (1 - numberPercent);
            Console.WriteLine($"{ freeSpace:F3}");
        }
    }
}
