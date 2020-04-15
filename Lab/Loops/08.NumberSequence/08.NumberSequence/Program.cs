using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int smallest = int.MaxValue;
            int biggest = int.MinValue;


            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                
                if (currentNum<smallest)
                {
                    smallest = currentNum;
                }

                if (currentNum>biggest)
                {
                    biggest = currentNum;
                }
            }
            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
