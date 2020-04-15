using System;

namespace _07.AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - 0.4 * rakiaPrice;
            double beerPrice = rakiaPrice - 0.8 * rakiaPrice;

            double whiskeySum = whiskeyPrice * whiskeyQuantity;
            double beerSum = beerPrice * beerQuantity;
            double wineSum = winePrice * wineQuantity;
            double rakiaSum = rakiaPrice * rakiaQuantity;

            double sum = whiskeySum + beerSum + wineSum + rakiaSum;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
