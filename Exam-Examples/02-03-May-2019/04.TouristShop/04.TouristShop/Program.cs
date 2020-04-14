using System;

namespace _04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string product = Console.ReadLine();
            double productsCost = 0;
            int counter = 0;

            double sum = 0;

            while (product != "Stop")
            {
                productsCost = 0;
                counter++;
                    
                
                productsCost = double.Parse(Console.ReadLine());

                if (counter % 3 == 0)
                {
                    productsCost = productsCost / 2;
                }
                sum += productsCost;

                if (budget < sum)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {sum-budget:F2} leva!");
                    Environment.Exit(0);
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"You bought {counter} products for {sum:F2} leva.");
        }
    }
}
