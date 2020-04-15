using System;

namespace _05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for(int i = 0; i < numbersCount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum % 2 == 0)
                {
                    p1++;
                }
                if (currentNum % 3 == 0)
                {
                    p2++;
                }
                if (currentNum % 4 == 0)
                {
                    p3++;
                }
            }
            double P1 = p1 * 1.0 / numbersCount * 100;
            double P2 = p2 * 1.0 / numbersCount * 100;
            double P3 = p3 * 1.0 / numbersCount * 100;

            Console.WriteLine($"{P1:F2}%");
            Console.WriteLine($"{P2:F2}%");
            Console.WriteLine($"{P3:F2}%");
        }
    }
}
