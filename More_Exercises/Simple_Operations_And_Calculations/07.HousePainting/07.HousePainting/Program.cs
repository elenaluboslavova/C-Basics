using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double frontSide = x * x - 1.2 * 2;
            double backSide = x * x ;
            double sideSides = 2 * (x * y - 1.5 * 1.5);
            double roof = 2 * (x * y) + x * h;

            double greenPaint = (frontSide + backSide + sideSides) / 3.4;
            double redPaint = roof / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
