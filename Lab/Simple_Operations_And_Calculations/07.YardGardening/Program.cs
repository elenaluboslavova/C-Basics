using System;

namespace _07.YardGardening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqMeters = double.Parse(Console.ReadLine());
            double sum = sqMeters * 7.61;
            double discount = sum * 0.18;
            double finalSum = sum - discount;
            Console.WriteLine($"The final price is: {finalSum:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
