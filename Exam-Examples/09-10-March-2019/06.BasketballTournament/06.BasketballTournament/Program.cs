using System;

namespace _06.BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int ourTeam = 0;
            int theirTeam = 0;
            int counter = 0;
            int won = 0;
            int lost = 0;

            while (input != "End of tournaments")
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {

                    counter++;
                    ourTeam = int.Parse(Console.ReadLine());
                    theirTeam = int.Parse(Console.ReadLine());

                    if (ourTeam > theirTeam)
                    {
                        won++;
                        Console.WriteLine($"Game {i} of tournament {input}: win with {ourTeam - theirTeam} points.");
                    }
                    else if (theirTeam > ourTeam)
                    {
                        lost++;
                        Console.WriteLine($"Game {i} of tournament {input}: lost with {theirTeam - ourTeam} points.");
                    }
                }
                


                input = Console.ReadLine();
            }
            Console.WriteLine($"{won * 1.0 / counter * 100:F2}% matches win");
            Console.WriteLine($"{lost * 1.0 / counter * 100:F2}% matches lost");
        }
    }
}
