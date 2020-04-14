using System;

namespace _01.Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double monthIncome = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());

            double unexpectedExpense = monthIncome * 30 / 100;
            double sum = monthIncome - (expenses + unexpectedExpense);
            double percent = sum / monthIncome*100;
            Console.WriteLine($"She can save {percent:F2}%");
            Console.WriteLine($"{sum*months:F2}");
        }
    }
}
