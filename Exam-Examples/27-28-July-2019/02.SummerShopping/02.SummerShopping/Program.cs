using System;

namespace _02.SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double umbrellaPrice = towelPrice * 2 / 3;
            double flipflopsPrice = umbrellaPrice * 75 / 100;
            double beachbagPrice = (flipflopsPrice + towelPrice) * 1 / 3;

            double sum = towelPrice + flipflopsPrice + umbrellaPrice + beachbagPrice;
            double finalSum = sum - sum * percent / 100;

            if (budget >= finalSum)
            {
                Console.WriteLine($"Annie's sum is {finalSum:F2} lv." +
                    $" She has {(budget-finalSum):F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {finalSum:F2} lv. She " +
                    $"needs {(finalSum-budget):F2} lv. more.");
            }

        }
    }
}
