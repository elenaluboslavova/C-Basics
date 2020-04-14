using System;

namespace _02.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            int rest = int.Parse(Console.ReadLine());

            double time = Math.Ceiling(rest*1.0 * 1 / 8 + rest*1.0 * 1 / 4 + episode*1.0);

            if (time>rest)
            {
                Console.WriteLine($"You don't have enough time to" +
                    $" watch {name}, you need {time-rest} more minutes.");
            }
            else
            {
                Console.WriteLine($"You have enough time to watch" +
                    $" {name} and left with {rest-time}" +
                    $" minutes free time.");
            }
        }
    }
}
