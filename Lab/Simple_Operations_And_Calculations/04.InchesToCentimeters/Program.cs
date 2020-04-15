using System;

namespace SantimetersToInches
{
    class Program
    {
        static void Main(string[] args)
        {
            double sant = double.Parse(Console.ReadLine());
            double inch = sant * 2.54;
            Console.WriteLine(inch);
        }
    }
}
