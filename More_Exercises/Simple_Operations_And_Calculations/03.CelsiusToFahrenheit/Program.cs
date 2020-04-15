using System;

namespace _03.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.80000 + 32.00;
            Console.WriteLine($"{fahrenheit:F2}");
        }
    }
}
