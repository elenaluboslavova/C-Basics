using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double workingHours = (days * 1.0 - 10 / 100 * days) * 8;
            double overtime = workers * days * 2 * 1.0;
            double finalHours = Math.Floor(workingHours + overtime);
            
            if (finalHours<hours)
            {
                Console.WriteLine($"Not enough time! {hours-finalHours} hours needed.");
            }
            else
            {
                Console.WriteLine($"Yes! {finalHours-hours} hours left.");
            }
        }
    }
}
