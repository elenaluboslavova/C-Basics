using System;

namespace _04.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengersStart = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());

            int leaving = 0;
            int coming = 0;
            for (int i = 1; i <= stops; i++)
            {
                leaving = int.Parse(Console.ReadLine());
                coming = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    coming += 2;
                }
                else
                {
                    leaving += 2;
                }
                passengersStart -= leaving;
                passengersStart += coming;
                
            }
            Console.WriteLine($"The final number of passengers is : {passengersStart}");
        }
    }
}
