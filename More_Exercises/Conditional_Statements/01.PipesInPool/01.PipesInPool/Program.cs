using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double liters = P1 * H + P2 * H;
            if (V>=liters)
            {
                Console.WriteLine($"The pool is {liters/V*100:F2}% full." +
                    $"Pipe 1: {P1*H/liters*100:F2}%." +
                    $"Pipe 2: {P2*H/liters*100:F2}%.");
            }
            else
            {
                Console.WriteLine($"For {H} hours the pool overflows" +
                    $"with {liters-V:F2} liters");
            }
        }
    }
}
