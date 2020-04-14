using System;

namespace _05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantityInKg = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int foodInGr = 0;
            int eatenFood = 0;

            while (command != "Adopted")
            {
                foodInGr = int.Parse(command);
                eatenFood += foodInGr;


                command = Console.ReadLine();
            }
            if (eatenFood <= foodQuantityInKg * 1000)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodQuantityInKg * 1000 - eatenFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {eatenFood - foodQuantityInKg * 1000} grams more.");
            }
        }
    }
}
