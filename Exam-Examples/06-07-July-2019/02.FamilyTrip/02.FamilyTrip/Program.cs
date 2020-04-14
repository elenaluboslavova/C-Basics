using System;

namespace _02.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            if (nights>7)
            {
                pricePerNight = pricePerNight - pricePerNight * 5 / 100;
            }
            double sum = nights * pricePerNight * 1.0 + budget * percent / 100;

            if (sum>budget)
            {
                Console.WriteLine($"{(sum-budget):F2} leva needed.");
            }
            else
            {
                Console.WriteLine($"Ivanovi will be left with {(budget-sum):F2}" +
                    $" leva after vacation.");
            }
        }
    }
}
