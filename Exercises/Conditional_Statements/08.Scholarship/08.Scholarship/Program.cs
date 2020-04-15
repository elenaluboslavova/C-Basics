using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double avg = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double social = 0;
            double money = 0;

            if (income < minSalary && avg > 4.50 && avg < 5.50)
            {
                social = Math.Floor(minSalary * 35 / 100);
            }
            else if (avg >= 5.50)
            {
                money = Math.Floor(avg * 25);
            }
            if (social>money)
            {
                Console.WriteLine($"You get a Social scholarship {social} BGN ");
            }
            else if(money > social)
            {
                Console.WriteLine($"You get a scholarship for " +
                    $"excellent results {money} BGN");
            }
            else
                Console.WriteLine("You cannot get a scholarship!");
            
        }
    }
}
