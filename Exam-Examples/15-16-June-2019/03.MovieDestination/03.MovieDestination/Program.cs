using System;

namespace _03.MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double money = 0;

            if (season == "Summer")
            {
                switch(destination)
                {
                    case "Dubai":
                        money = days * 40000 - days * 40000 * 0.3;
                        break;
                    case "Sofia":
                        money = days * 12500 + days * 12500 * 0.25;
                        break;
                    case "London":
                        money = days * 20250;
                        break;
                }
            }

            else if (season == "Winter")
            {
                switch (destination)
                {
                    case "Dubai":
                        money = days * 45000 - days * 45000 * 0.3;
                        break;
                    case "Sofia":
                        money = days * 17000 + days * 17000 * 0.25;
                        break;
                    case "London":
                        money = days * 24000;
                        break;
                }
            }

            if (budget >= money)
            {
                Console.WriteLine($"The budget for the movie is enough! " +
                    $"We have {budget-money:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {money-budget:F2} leva more!");
            }
        }
    }
}
