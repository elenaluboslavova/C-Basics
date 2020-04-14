using System;

namespace _02.MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int timePerScene = int.Parse(Console.ReadLine());

            double preparation = time * 15 / 100;
            double neededTime = scenes * timePerScene + preparation;

            if (time>=neededTime)
            {
                Console.WriteLine($"You managed to finish the movie" +
                    $" on time! You have {Math.Round(time-neededTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie " +
                    $"you need {Math.Round(neededTime-time)} minutes.");
            }
        }
    }
}
