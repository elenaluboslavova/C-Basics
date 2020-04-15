using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());
            int playingMinutes = freeDays * 127 + (365 - freeDays) * 63;
            if (playingMinutes>30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(playingMinutes-30000)/60} hours and " +
                    $"{(playingMinutes-30000)%60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(30000-playingMinutes)/60} hours" +
                    $" and {(30000-playingMinutes)%60} minutes less for play");
            }
        }
    }
}
