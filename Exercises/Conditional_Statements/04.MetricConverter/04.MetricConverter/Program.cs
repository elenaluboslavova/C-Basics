using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string m1 = Console.ReadLine();
            string m2 = Console.ReadLine();

            if (m1=="mm" && m2=="m")
            {
                Console.WriteLine($"{(number / 1000):F3}");
            }
            else if(m1=="mm" && m2=="cm")
            {
                Console.WriteLine($"{(number / 10):F3}");
            }
            else if (m1 == "cm" && m2 == "m")
            {
                Console.WriteLine($"{(number / 100):F3}");
            }
            else if (m1 == "cm" && m2 == "mm")
            {
                Console.WriteLine($"{(number * 10):F3}");
            }
            else if (m1 == "m" && m2 == "cm")
            {
                Console.WriteLine($"{(number * 100):F3}");
            }
            else if (m1 == "m" && m2 == "mm")
            {
                Console.WriteLine($"{(number * 1000):F3}");
            }
        }
    }
}
