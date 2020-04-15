using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            double neededFood = (dogFood + catFood + turtleFood / 1000) * days;
            if (neededFood>food)
            {
                Console.WriteLine($"{Math.Ceiling(neededFood-food)} more kilos of food are needed.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(food-neededFood)} kilos of food left.");
            }
        }
    }
}
