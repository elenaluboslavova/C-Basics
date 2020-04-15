using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int otherFood = int.Parse(Console.ReadLine());
            double Food1 = dogFood * 2.50;
            double Food2 = otherFood * 4;
            double sum = Food1 + Food2;
            Console.WriteLine($"{sum:F2} lv.");

        }
    }
}
