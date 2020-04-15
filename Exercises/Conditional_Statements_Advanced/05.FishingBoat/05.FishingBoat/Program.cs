using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double rent = 0;
            double discount = 0;
            double additionalDiscount = 0;
            double sum = 0;
            double finalSum = 0;

            if (fisherman <= 6)
            {
                discount = 0.1;
            }
            else if (fisherman > 7 && fisherman <= 11)
            {
                discount = 0.15;
            }
            else if (fisherman > 12)
            {
                discount = 0.25;
            }

            if (fisherman%2==0)
            {
                additionalDiscount = 0.05;
                if (season=="Autumn")
                {
                    additionalDiscount = 0;
                }
            }

            if (season=="Spring")
            {
                rent = 3000;
                
            }
            else if (season=="Summer" || season=="Autumn")
            {
                rent = 4200;
            }
            else if (season=="Winter")
            {
                rent = 2600;
            }

            sum = rent - rent * discount;
            finalSum = sum - sum * additionalDiscount;

            if (budget>=finalSum)
            {
                Console.WriteLine($"Yes! You have {(budget-finalSum):F2}" +
                    $" leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need " +
                    $"{(finalSum-budget):F2} leva.");
            }
        }
    }
}
