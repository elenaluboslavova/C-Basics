using System;

namespace _06.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int one = Convert.ToInt32(number[0])-48;
            int two = Convert.ToInt32(number[1])-48;
            int three = Convert.ToInt32(number[2])-48;


            for (int i = 1; i <= three; i++)
            {
                for (int j = 1; j <= two; j++)
                {
                    for (int l = 1; l <= one; l++)
                    {
                        Console.WriteLine($"{i} * {j} * {l} = {i*j*l};");
                    }
                }
            }
        }
    }
}
