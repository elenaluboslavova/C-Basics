using System;

namespace _03.LuggageTax
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            string isPriority = Console.ReadLine();

            int luggage = width * height * depth;

            int tax = 0;

            if (luggage > 50 && luggage <= 100)
            {
                switch(isPriority)
                {
                    case "true":
                        tax = 0;
                        break;
                    case "false":
                        tax = 25;
                        break;
                }
            }

            else if (luggage > 100 && luggage <= 200)
            {
                switch (isPriority)
                {
                    case "true":
                        tax = 10;
                        break;
                    case "false":
                        tax = 50;
                        break;
                }
            }

            else if (luggage > 200 && luggage <= 300)
            {
                switch (isPriority)
                {
                    case "true":
                        tax = 20;
                        break;
                    case "false":
                        tax = 100;
                        break;
                }
            }

            Console.WriteLine($"Luggage tax: {tax:F2}");
        }
    }
}
