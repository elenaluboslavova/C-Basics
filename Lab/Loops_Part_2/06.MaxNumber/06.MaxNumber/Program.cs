using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int i = 0;

            while (i<n)
            {
                int num = int.Parse(Console.ReadLine());
                i++;
                
                if (num > max)
                {
                    max = num;
                }
                
            }
            Console.WriteLine(max);
        }
    }
}
