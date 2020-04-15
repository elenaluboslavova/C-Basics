using System;

namespace _04.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i = 2 * i + 1)
            //{
            //    Console.WriteLine(i);
            //}

            int i = 1;

            while (i <= n)
            {
                Console.WriteLine(i);
                i = 2 * i + 1;
            }
            
        }
    }
}
