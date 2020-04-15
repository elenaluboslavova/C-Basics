using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            //скумрия
            double mackerelPrice = double.Parse(Console.ReadLine());
            //цаца
            double spratPrice = double.Parse(Console.ReadLine());
            //паламуд
            double chamoisKg = double.Parse(Console.ReadLine());
            //сафрид
            double scadKg = double.Parse(Console.ReadLine());
            //миди
            double musselsKg = double.Parse(Console.ReadLine());

            double chamoisPrice = mackerelPrice + mackerelPrice * 6 / 10;
            double scadPrice = spratPrice + spratPrice * 8 / 10;
            double musselsPrice = 7.50;

            double sum = chamoisKg * chamoisPrice + scadKg * scadPrice + musselsKg * musselsPrice;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
