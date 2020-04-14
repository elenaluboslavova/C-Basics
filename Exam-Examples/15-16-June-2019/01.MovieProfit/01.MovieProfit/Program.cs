using System;

namespace _01.MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int ticketsCount = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double sum = days * ticketsCount * ticketPrice * percent / 100;
            double finalSum = days * ticketPrice * ticketsCount - sum;
            Console.WriteLine($"The profit from the movie {name} is {finalSum:F2} lv.");
        }
    }
}
