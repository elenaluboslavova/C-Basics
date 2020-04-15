using System;

namespace _10.WeatherForecast_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());

            if (35<=degree && degree>=26.00)
            {
                Console.WriteLine("Hot");
            }
            else if(degree<=25.9 && degree>=20.1)
            {
                Console.WriteLine("Warm");
            }
            else if(degree<=20.00 && degree>=15.00)
            {
                Console.WriteLine("Mild");
            }
            else if(degree<=14.9 && degree>=12.00)
            {
                Console.WriteLine("Cool");
            }
            else if(degree<=11.9 && degree>=5.00)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
