using System;

namespace _01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double transport = 0;

            if (category == "VIP")
            {
                ticketPrice = 499.99;
            }
            else if (category == "Normal")
            {
                ticketPrice = 249.99;
            }

            if (peopleCount >= 1 && peopleCount <= 4)
            {
                transport = budget * 0.75;
            }
            else if (peopleCount >= 5 && peopleCount <= 9)
            {
                transport = budget * 0.6;
            }
            else if (peopleCount >= 10 && peopleCount <= 24)
            {
                transport = budget * 0.5;
            }
            else if (peopleCount >= 25 && peopleCount <= 49)
            {
                transport = budget * 0.4;
            }
            else if (peopleCount >= 50)
            {
                transport = budget * 0.25;
            }
            double finalSum = ticketPrice * peopleCount + transport;
            if (finalSum > budget)
            {
                Console.WriteLine($"Not enough money! You need {finalSum-budget:F2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {budget-finalSum:F2} leva left.");
            }
        }
    }
}
