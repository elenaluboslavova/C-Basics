using System;

namespace _05.EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterbread = int.Parse(Console.ReadLine());

            int sugar = 0;
            int flour = 0;
            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;

            double sugarCount = 0;
            double flourCount = 0;

            double neededSugar = 0;
            double neededFlour = 0;

            for (int i = 0; i < easterbread; i++)
            {
                sugar = int.Parse(Console.ReadLine());
                flour = int.Parse(Console.ReadLine());

                if (sugar > maxSugar)
                {
                    maxSugar = sugar;
                }
                if (flour > maxFlour)
                {
                    maxFlour = flour;
                }

                sugarCount += sugar;
                flourCount += flour;

                neededSugar = Math.Ceiling(sugarCount / 950);
                neededFlour = Math.Ceiling(flourCount / 750);

            }

            Console.WriteLine($"Sugar: {neededSugar}");
            Console.WriteLine($"Flour: {neededFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar" +
                $" is {maxSugar} grams.");
        }
    }
}
