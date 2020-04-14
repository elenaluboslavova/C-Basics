using System;

namespace _04.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string command = Console.ReadLine();

            int finalPoints = 301;

            int counter = 0;
            int counter1 = 0;

            while (command != "Retire")
            {
                int points = int.Parse(Console.ReadLine());

                
                if (command == "Single")
                {
                    if (points > finalPoints)
                    {
                        counter1++;
                    }
                    else
                    {
                        finalPoints -= points;
                        counter++;
                    }
                }
                else if (command == "Double")
                {
                    if (points * 2 > finalPoints)
                    {
                        counter1++;
                    }
                    else
                    {
                        finalPoints -= points * 2;
                        counter++;
                    }
                }
                else if (command == "Triple")
                {
                    if (points * 3 > finalPoints)
                    {
                        counter1++;
                    }
                    else
                    {
                        finalPoints -= points * 3;
                        counter++;
                    }
                }

                if (finalPoints == 0)
                {
                    Console.WriteLine($"{name} won the leg with {counter} shots.");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{name} retired after {counter1} unsuccessful shots.");
        }
    }
}
