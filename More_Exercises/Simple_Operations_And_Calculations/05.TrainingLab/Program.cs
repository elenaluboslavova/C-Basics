using System;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double row = Math.Floor((h * 100 - 100) / 70);
            double column = Math.Floor(w * 100 / 120);
            double seats = Math.Floor(row * column - 3);
            Console.WriteLine(seats);
        }
    }
}
