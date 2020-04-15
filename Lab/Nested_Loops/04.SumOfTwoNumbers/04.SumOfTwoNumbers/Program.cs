using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = x; i <= y; i++)
            {
                for (int k = x; k <= y; k++)
                {
                    counter++;
                    sum = i + k;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter}" +
                            $" ({i} + {k} = {magicNumber})");
                        return;
                    }
                }
                
            }
            if (sum != magicNumber)
            {
                Console.WriteLine($"{counter} combinations - " +
                            $"neither equals {magicNumber}");
            }
        }
    }
}
