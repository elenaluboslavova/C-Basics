using System;

namespace _03.LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            if (i + j == l + m && n % (i + j) == 0)
                            {
                                Console.Write($"{i}{j}{l}{m} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
