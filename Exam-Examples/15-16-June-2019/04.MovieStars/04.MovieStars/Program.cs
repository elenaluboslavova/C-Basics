using System;

namespace _04.MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            double money = 0;

            while (command != "ACTION")
            {
                string actor = command;
                if (actor.Length <= 15)
                {
                    money = double.Parse(Console.ReadLine());
                    budget -= money;
                }
                else
                {
                    money = budget * 0.2;
                    budget -= money;
                }

                if (budget <= 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budget):F2} leva for our actors.");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"We are left with {budget:F2} leva.");
        }
    }
}
