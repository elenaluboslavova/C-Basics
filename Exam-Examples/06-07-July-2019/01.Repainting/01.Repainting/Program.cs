using System;

namespace _01.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylon*1.0+2) * 1.50;
            double paintPrice = (paint*1.0+paint*1.0*10/100) * 14.50;
            double diluentPrice = diluent*1.0 * 5.00;
            double sum = nylonPrice + paintPrice + diluentPrice + 0.40;
            double hoursPrice = sum * 30 / 100;
            double finalSum = sum + hours * hoursPrice;
            Console.WriteLine($"Total expenses: {finalSum:F2} lv.");
        }
    }
}
