using System;

namespace _05.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());

            double points = 0;
            double finalPoints = 0;

            for (int i = 0; i < jury; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());
                points = juryName.Length * juryPoints / 2;
                finalPoints += points;
    
                if (finalPoints + academyPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {finalPoints+academyPoints:F1}!");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {actor} you need {1250.5-finalPoints-academyPoints:F1} more!");
        }
    }
}
