using System;

namespace _01.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenuCount = int.Parse(Console.ReadLine());
            int fishMenuCount = int.Parse(Console.ReadLine());
            int vegeMenuCount = int.Parse(Console.ReadLine());

            double sum = chickenMenuCount * 10.35 + fishMenuCount * 12.40 +
                vegeMenuCount * 8.15;
            double dessert = sum * 20 / 100;
            double finalSum = sum + dessert + 2.50;
            Console.WriteLine($"Total: {finalSum:F2}");
        }
    }
}
