using System;

namespace _04.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsFirst = int.Parse(Console.ReadLine());
            int eggsSecond = int.Parse(Console.ReadLine());

            string command = "";
            int n = eggsFirst + eggsSecond;

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                if (command == "one")
                {
                    eggsSecond--;
                }
                else if (command == "two")
                {
                    eggsFirst--;
                }
                if (command == "End of battle")
                {
                    Console.WriteLine($"Player one has {eggsFirst} eggs left.");
                    Console.WriteLine($"Player two has {eggsSecond} eggs left.");
                    Environment.Exit(0);
                }
                if (eggsFirst <= 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has" +
                        $" {eggsSecond} eggs left.");
                    Environment.Exit(0);
                }
                if (eggsSecond <= 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has" +
                        $" {eggsFirst} eggs left.");
                    Environment.Exit(0);
                }
            }
            
        }
    }
}
