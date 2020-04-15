using System;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fensCount = int.Parse(Console.ReadLine());
            double pra = 0;
            double prb = 0;
            double prv = 0;
            double prg = 0;


            for (int i = 0; i < fensCount; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                if (sector == 'A')
                {
                    pra++;
                }
                else if (sector == 'B')
                {
                    prb++;
                }
                else if (sector == 'V')
                {
                    prv++;
                }
                else if (sector == 'G')
                {
                    prg++;
                }
            }
            Console.WriteLine($"{pra / fensCount * 100:F2}%");
            Console.WriteLine($"{prb / fensCount * 100:F2}%");
            Console.WriteLine($"{prv / fensCount * 100:F2}%");
            Console.WriteLine($"{prg / fensCount * 100:F2}%");
            Console.WriteLine($"{fensCount * 1.0 / stadiumCapacity * 100:F2}%");
        }
    }
}
