using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakePrice = 45;
            double wafflePrice = 5.80;
            double pancakePrice = 3.20;

            double sum = days * bakers * 1.0 * (cakes * cakePrice +
                waffles * wafflePrice + pancakes * pancakePrice);
            double finalSum = sum - sum * 1 / 8;
            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
