using System;

namespace _05.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double hallArea = L * 100 * W * 100;
            double bench =  hallArea / 10;
            double wardrobeArea = A * 100 * A * 100;
            double dancerArea = 40 + 7000;
            double dancers = (hallArea - wardrobeArea - bench) / dancerArea;
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
