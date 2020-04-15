using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeMovie = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            switch(typeMovie)
            {
                case "Premiere": Console.WriteLine($"{(r * c * 12.00):F2}");
                    break;
                case "Normal": Console.WriteLine($"{(r * c * 7.50):F2}");
                    break;
                case "Discount": Console.WriteLine($"{(r * c * 5.00):F2}");
                    break;
            }
        }
    }
}
