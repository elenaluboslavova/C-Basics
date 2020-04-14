using System;

namespace _02.SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double pricePerTowel = double.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            double pricePerUmbrella = pricePerTowel * 2 / 3;
            double pricePerFlipFlops = pricePerUmbrella * 0.75;
            double pricePerBag = (pricePerFlipFlops + pricePerTowel) * 1 / 3;

            double sum = pricePerTowel + pricePerUmbrella + pricePerFlipFlops + pricePerBag;
            double finalSum = sum - sum * discountPercent / 100;

            if (budget >= finalSum)
            {
                Console.WriteLine($"Annie's sum is {finalSum:F2} lv. She has {budget-finalSum:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {finalSum:F2} lv. She needs {finalSum-budget:F2} lv. more.");
            }
        }
    }
}
