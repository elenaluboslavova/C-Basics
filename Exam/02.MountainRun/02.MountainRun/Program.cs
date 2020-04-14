using System;

namespace _02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsPerMeter = double.Parse(Console.ReadLine());

            double time = distanceInMeters * timeInSecondsPerMeter + Math.Floor(distanceInMeters / 50)*30;

            if (time >= recordInSeconds)
            {
                Console.WriteLine($"No! He was {time - recordInSeconds:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {time:F2} seconds.");
            }
        }
    }
}
