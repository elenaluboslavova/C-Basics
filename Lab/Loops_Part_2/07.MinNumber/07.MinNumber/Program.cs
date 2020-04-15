using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number<minNum)
                {
                    minNum = number;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
