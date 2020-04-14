using System;

namespace _01.LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double lemonsKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            double waterLiters = double.Parse(Console.ReadLine());

            double lemonJuiceMl = lemonsKg * 980;
            double lemonade = waterLiters * 1000 + lemonJuiceMl + sugarKg * 30 / 100;
            double cups = Math.Floor(lemonade / 150);
            double profit = cups * 1.20;
            Console.WriteLine($"All cups sold: {cups}");
            Console.WriteLine($"Money earned: {profit:F2}");
        }
    }
}
