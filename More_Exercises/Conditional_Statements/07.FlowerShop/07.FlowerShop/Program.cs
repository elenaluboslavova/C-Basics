using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinth = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cacti = int.Parse(Console.ReadLine());
            double gift = double.Parse(Console.ReadLine());

            double sum = magnolias * 3.25 + hyacinth * 4 + roses * 3.50 +
                cacti * 8;
            double finalSum = sum * 95 / 100;

            if (finalSum>=gift)
            {
                Console.WriteLine($"She is left with {Math.Floor(finalSum-gift)}" +
                    $" leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(gift-finalSum)}" +
                    $" leva.");
            }
        }
    }
}
