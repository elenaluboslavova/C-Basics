using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());


            double firstTime = distance * secondsPerMeter;
            double resistance = Math.Floor(distance / 15) * 12.5;
            double time = firstTime + resistance;
            if (recordTime>time)
            {
                Console.WriteLine($"Yes, he succeeded! The new world" +
                    $" record is {time:F2} seconds.");

            }
            else
            {
                Console.WriteLine($"No, he failed! He was " +
                    $"{(time-recordTime):F2} seconds slower.");
            }
        }
    }
}
