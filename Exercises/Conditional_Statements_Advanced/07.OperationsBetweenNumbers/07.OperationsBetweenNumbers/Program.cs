using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            string a = "";
            
            switch (symbol)
            {
                case '+':
                    if ((N1+N2)%2==0)
                    {
                        a = "even";
                    }
                    else
                    {
                        a = "odd";
                    }
                    Console.WriteLine($"{N1} + {N2} = {N1+N2} - {a}");
                    break;

                case '-':
                    if ((N1 - N2) % 2 == 0)
                    {
                        a = "even";
                    }
                    else
                    {
                        a = "odd";
                    }
                    Console.WriteLine($"{N1} - {N2} = {N1 - N2} - {a}");
                    break;

                case '*':
                    if ((N1 * N2) % 2 == 0)
                    {
                        a = "even";
                    }
                    else
                    {
                        a = "odd";
                    }
                    Console.WriteLine($"{N1} * {N2} = {N1 * N2} - {a}");
                    break;

                case '/':
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} / {N2} = {(N1 * 1.0 / N2):F2}");
                    }
                    break;

                case '%':
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} % {N2} = {N1 % N2}");
                    }
                    break;
            }

            
        }
    }
}
