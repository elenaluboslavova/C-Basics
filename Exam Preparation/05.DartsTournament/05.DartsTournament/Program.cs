using System;

namespace _05.DartsTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int points = 0;
            int counter = 1;

            while (command != "bullseye")
            {
                points = int.Parse(Console.ReadLine());
                if (command == "double ring")
                {
                    points = points * 2;
                }
                else if (command == "triple ring")
                {
                    points = points * 3;
                }
                startingPoints -= points;

                if (startingPoints == 0 )
                {
                    Console.WriteLine($"Congratulations! You won the game in {counter} moves!");
                    return;
                }
                else if (startingPoints < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(startingPoints)}.");
                    return;
                }

                command = Console.ReadLine();
                counter++;
            }
            Console.WriteLine($"Congratulations! You won the game with a bullseye in {counter} moves!");
        }
    }
}
