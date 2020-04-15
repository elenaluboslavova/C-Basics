using System;

namespace _04.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double discount = 0;
            double sum = 0;
            //roses, dahlias, tulips, narcissus, gladiolus

            if (flower=="Roses")
            {
                if (flowerCount > 80)
                {
                    discount = 0.1;
                }
                sum = flowerCount * 5.0 - flowerCount * 5.0 * discount;
            }

            else if (flower=="Dahlias")
            {
                if (flowerCount > 90)
                {
                    discount = 0.15;
                }
                sum = flowerCount * 3.80 - flowerCount * 3.80 * discount;
            }

            else if (flower=="Tulips")
            {
                if (flowerCount > 80)
                {
                    discount = 0.15;
                }
                sum = flowerCount * 2.80 - flowerCount * 2.80 * discount;
            }
            else if (flower=="Narcissus")
            {
                if (flowerCount < 120)
                {
                    discount = 0.15;
                }
                sum = flowerCount * 3.0 + flowerCount * 3.0 * discount;
            }
            else if (flower=="Gladiolus")
            {
                if (flowerCount < 80)
                {
                    discount = 0.2;
                }
                sum = flowerCount * 2.50 + flowerCount * 2.50 * discount;
            }

            if (budget>=sum)
            {
                Console.WriteLine($"Hey, you have a great garden with" +
                    $" {flowerCount} {flower} and {(budget-sum):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need " +
                    $"{(sum-budget):F2} leva more.");
            }
        }
    }
}
