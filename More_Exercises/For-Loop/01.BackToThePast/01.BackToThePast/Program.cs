using System;

namespace _01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int counter = 0;
            int yearCounter = 0;
            double spendedMoney = 0;
            double finalMoney = 0;

            for (int i = 0; i <= year-1800; i++)
            {
                yearCounter = 1800 + counter;
                if (yearCounter % 2 == 0)
                {
                    spendedMoney = 12000;
                }
                else
                {
                    spendedMoney = 12000 + 50 * (18 + counter);
                }
                finalMoney += spendedMoney;
                counter++;
            }
            if (finalMoney<=inheritedMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney-finalMoney:F2}" +
                    $" dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {finalMoney-inheritedMoney:F2} " +
                    $"dollars to survive.");
            }

        }
    }
}
