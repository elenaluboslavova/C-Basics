using System;

namespace _04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodQuantity = double.Parse(Console.ReadLine());

            int dogFood = 0;
            int catFood = 0;
            double biscuits = 0;
            int allDogFood = 0;
            int allCatFood = 0;
            double allBiscuits = 0;

            for (int i = 1; i <= days; i++)
            {
                dogFood = int.Parse(Console.ReadLine());
                catFood = int.Parse(Console.ReadLine());

                allDogFood += dogFood;
                allCatFood += catFood;
                if (i % 3 == 0)
                {
                    biscuits = (dogFood + catFood) * 0.1;
                    allBiscuits += biscuits;
                }
            }
            Console.WriteLine($"Total eaten biscuits: {allBiscuits:F0}gr.");
            Console.WriteLine($"{(allDogFood + allCatFood) / foodQuantity * 100:F2}% of the food has been eaten.");
            Console.WriteLine($"{allDogFood * 1.0 / (allDogFood + allCatFood) * 100:F2}% eaten from the dog.");
            Console.WriteLine($"{allCatFood * 1.0 / (allDogFood + allCatFood) * 100:F2}% eaten from the cat.");
        }
    }
}
