using System;

namespace _02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double menu = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cake = budget * 10 / 100;

            if (guests>=10 && guests<=15)
            {
                double sum = guests * menu - guests * menu * 15 / 100 + cake;
                if (sum>budget)
                {
                    Console.WriteLine($"No party! {(sum-budget):F2} leva needed.");
                }
                else
                {
                    Console.WriteLine($"It is party time! {(budget-sum):F2} leva left.");
                }
            }
            else if (guests>15 && guests<=20)
            {
                double sum = guests * menu - guests * menu * 20 / 100 + cake;
                if (sum > budget)
                {
                    Console.WriteLine($"No party! {(sum - budget):F2} leva needed.");
                }
                else
                {
                    Console.WriteLine($"It is party time! {(budget - sum):F2} leva left.");
                }
            }
            else if (guests>20)
            {
                double sum= guests * menu - guests * menu * 25 / 100 + cake;
                if (sum > budget)
                {
                    Console.WriteLine($"No party! {(sum - budget):F2} leva needed.");
                }
                else
                {
                    Console.WriteLine($"It is party time! {(budget - sum):F2} leva left.");
                }
            }
            else
            {
                double sum = guests * menu + cake;
                if (sum > budget)
                {
                    Console.WriteLine($"No party! {(sum - budget):F2} leva needed.");
                }
                else
                {
                    Console.WriteLine($"It is party time! {(budget - sum):F2} leva left.");
                }
            }
        }
    }
}
