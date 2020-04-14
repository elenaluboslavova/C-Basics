using System;

namespace _05.PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string game = "";
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            for (int i = 1; i <= n; i++)
            {
                game = Console.ReadLine();

                switch(game)
                {
                    case "Hearthstone":
                        count1++;
                        break;
                    case "Fornite":
                        count2++;
                        break;
                    case "Overwatch":
                        count3++;
                        break;
                    default:
                        count4++;
                        break;
                }
            }
            Console.WriteLine($"Hearthstone - {count1 * 1.0 / n * 100 :F2}%");
            Console.WriteLine($"Fornite - {count2 * 1.0 / n * 100:F2}%");
            Console.WriteLine($"Overwatch - {count3 * 1.0 / n * 100:F2}%");
            Console.WriteLine($"Others - {count4 * 1.0 / n * 100:F2}%");
        }
    }
}
