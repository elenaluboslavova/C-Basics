using System;

namespace _02.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double easterbread = Math.Ceiling(guests * 1.0 / 3);
            double eggs = guests * 2;
            double sum = easterbread * 4 + eggs * 0.45;

            if (sum>budget)
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {(sum-budget):F2} lv. more.");
            }
            else
            {
                Console.WriteLine($"Lyubo bought {easterbread} Easter bread" +
                    $" and {eggs} eggs.");
                Console.WriteLine($"He has {(budget-sum):F2} lv. left.");
            }
        }
    }
}
