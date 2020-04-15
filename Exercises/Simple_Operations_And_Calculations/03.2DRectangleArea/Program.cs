using System;

namespace _03._2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double a = Math.Abs(x1-x2);
            double b = Math.Abs(y1-y2);

            double area = a * b;
            double p = 2 * a + 2 * b;

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{p:F2}");
        }
    }
}
