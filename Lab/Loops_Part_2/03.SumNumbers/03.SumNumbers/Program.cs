using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int number = 0;
            int sum = 0;
             
            while (command != "Stop")
            {
                number = int.Parse(command);
                command = Console.ReadLine();
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
