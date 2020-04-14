using System;

namespace _04.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());

            string command = "";
            int eggsShop = 0;
            int sold = 0;

            for (int i = 0; i < 100; i++)
            {
                command = Console.ReadLine();
                if (command == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{sold} eggs sold.");
                    Environment.Exit(0);
                }
                eggsShop = int.Parse(Console.ReadLine());

                if (command == "Buy")
                {
                    if (eggsShop > eggs)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggs}.");
                        Environment.Exit(0);
                    }
                    sold += eggsShop;
                    eggs -= eggsShop;
                }
                if (command == "Fill")
                {
                    eggs += eggsShop;
                }
            }
        }
    }
}
