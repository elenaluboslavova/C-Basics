using System;

namespace _09.MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            for (int i = 0; i < 100; i++)
            {
                number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Negative number!");
                    Environment.Exit(0);
                }
                Console.WriteLine($"Result: {number * 2:F2}");
            }
        }
    }
}
