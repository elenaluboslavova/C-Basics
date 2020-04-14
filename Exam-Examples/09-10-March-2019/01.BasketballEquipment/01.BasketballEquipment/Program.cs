using System;

namespace _01.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int feePerYear = int.Parse(Console.ReadLine());

            double shoes = feePerYear - feePerYear * 40 / 100;
            double outfit = shoes - shoes * 20 / 100;
            double ball = outfit * 1 / 4;
            double accessories = ball * 1 / 5;
            double sum = shoes + outfit + ball + accessories + feePerYear;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
