using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tables = double.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double tableclothArea = tables * ((tableLength + 2 * 0.30) * (tableWidth + 2 * 0.30));

            double squareArea = tables * ((tableLength / 2) * (tableLength / 2));

            double sumUSD = tableclothArea * 7 + squareArea * 9;
            double sumBGN = sumUSD * 1.85;

            Console.WriteLine($"{sumUSD:F2} USD");
            Console.WriteLine($"{sumBGN:F2} BGN");
        }
    }
}
