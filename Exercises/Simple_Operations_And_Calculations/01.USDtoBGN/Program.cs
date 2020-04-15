using System;

namespace _01.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79546;
            Console.WriteLine($"{bgn:F2} BGN");
        }
    }
}
