using System;

namespace _02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double lengthInMeters = double.Parse(Console.ReadLine());
            int secondsPer100Meters = int.Parse(Console.ReadLine());

            int time = minutes * 60 + seconds;
            double hisTime = lengthInMeters * secondsPer100Meters / 100 - lengthInMeters / 120 * 2.5;
            if (time>=hisTime)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {hisTime:F3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {(hisTime-time):F3} second slower.");
            }
        }
    }
}
