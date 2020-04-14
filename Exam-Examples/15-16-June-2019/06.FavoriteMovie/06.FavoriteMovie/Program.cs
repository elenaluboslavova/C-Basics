using System;

namespace _06.FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int counter = 0;
            string bestFilm = "";
            int bestSum = 0;

            while (command != "STOP")
            {
                int sum = 0;
                counter++;
                if (counter > 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
                for (int i = 0; i < command.Length; i++)
                {
                    if (Char.IsUpper(command[i]))
                    {
                        sum += command[i] - command.Length;
                    }
                    else if (Char.IsLower(command[i]))
                    {
                        sum += command[i] - 2 * command.Length;
                    }
                    else
                    {
                        sum += command[i];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestFilm = command;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The best movie for you is {bestFilm} with {bestSum} ASCII sum.");
        }
    }
}
