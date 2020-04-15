using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {architect} will need { projects*3} hours to complete { projects} project/s.");
        }
    }
}
