using System;

namespace _01.Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double monthlyIncome = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double neededSum = double.Parse(Console.ReadLine());

            double sum = (monthlyIncome - neededSum - monthlyIncome * 0.3) * months;

            Console.WriteLine($"She can save {sum / months / monthlyIncome * 100:F2}%");
            Console.WriteLine($"{sum:F2}");
        }
    }
}
