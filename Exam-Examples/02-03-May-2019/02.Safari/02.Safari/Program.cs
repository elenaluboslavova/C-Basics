using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (day=="Saturday")
            {
                double sum = fuel * 2.10 + 100 - (fuel * 2.10 + 100) * 10 / 100;
                if (sum>budget)
                {
                    Console.WriteLine($"Not enough money! Money" +
                        $" needed: {(sum-budget):F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Safari time! Money left:" +
                        $" {(budget-sum):F2} lv.");
                }
            }
            else if (day=="Sunday")
            {
                double sum = fuel * 2.10 + 100 - (fuel * 2.10 + 100) * 20 / 100;
                if (sum > budget)
                {
                    Console.WriteLine($"Not enough money! Money" +
                        $" needed: {(sum - budget):F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Safari time! Money left:" +
                        $" {(budget - sum):F2} lv.");
                }
            }
        }
    }
}
