using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            double sum = 0;

            while (i < n)
            {
                double payment = double.Parse(Console.ReadLine());
                

                if (payment < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {payment:F2}");
                i++;
                sum += payment;
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
