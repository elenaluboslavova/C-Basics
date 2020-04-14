using System;

namespace _05.FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());

            string activity = "";
            int counterBack = 0;
            int counterChest = 0;
            int counterLegs = 0;
            int counterAbs = 0;
            int counterProteinShake = 0;
            int counterProteinBar = 0;
            int counterWorkOut = 0;
            int counterProtein = 0;

            for (int i = 0; i < clients; i++)
            {
                activity = Console.ReadLine();
                switch(activity)
                {
                    case "Back":
                        counterBack++;
                        counterWorkOut++;
                        break;
                    case "Chest":
                        counterChest++;
                        counterWorkOut++;
                        break;
                    case "Legs":
                        counterLegs++;
                        counterWorkOut++;
                        break;
                    case "Abs":
                        counterAbs++;
                        counterWorkOut++;
                        break;
                    case "Protein shake":
                        counterProteinShake++;
                        counterProtein++;
                        break;
                    case "Protein bar":
                        counterProteinBar++;
                        counterProtein++;
                        break;
                }
            }
            Console.WriteLine($"{counterBack} - back");
            Console.WriteLine($"{counterChest} - chest");
            Console.WriteLine($"{counterLegs} - legs");
            Console.WriteLine($"{counterAbs} - abs");
            Console.WriteLine($"{counterProteinShake} - protein shake");
            Console.WriteLine($"{counterProteinBar} - protein bar");
            Console.WriteLine($"{counterWorkOut * 1.0 / clients * 100:F2}% - work out");
            Console.WriteLine($"{counterProtein * 1.0 / clients * 100:F2}% - protein");
        }
    }
}
