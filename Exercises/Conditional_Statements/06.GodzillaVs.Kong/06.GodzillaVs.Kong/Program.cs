using System;

namespace _06.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double statistPrice = double.Parse(Console.ReadLine());

            double decor = budget * 10 / 100;
            if (statists>150)
            {
                double statistDiscount = statistPrice - statistPrice * 10 / 100;
                double sum = statists * statistDiscount + decor;
                if (sum>budget)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {(sum-budget):F2} leva more.");
                }
                else
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {(budget - sum):F2} leva left.");

                }
            }
            else
            {
                double sum = statistPrice * statists + decor;
                if (sum > budget)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {(sum - budget):F2} leva more.");
                }
                else
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {(budget-sum):F2} leva left.");
                }
            }
        }
    }
}
