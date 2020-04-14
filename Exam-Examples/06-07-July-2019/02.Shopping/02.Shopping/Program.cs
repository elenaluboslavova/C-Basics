using System;

namespace _02.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nCount = int.Parse(Console.ReadLine());
            int mCount = int.Parse(Console.ReadLine());
            int pCount = int.Parse(Console.ReadLine());

            double sum = 0;

            int n = 250;
            double m = n * nCount * 1.0 * 35 / 100;
            double p = n * nCount * 1.0 * 1 / 10;
            sum = n * nCount + m * mCount + p * pCount;
            if (nCount > mCount)
            {
                sum = sum - sum * 15 / 100;
            }

            if (budget>=sum)
            {
                Console.WriteLine($"You have {(budget-sum):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(sum-budget):F2}" +
                    $" leva more!");
            }
        }
    }
}
