using System;

namespace _04.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int litersPaint = 0;
            double allPaint = 0;
            double paintedRoom = 0;

            double room = Math.Ceiling(4 * height * width - percent * 1.0 / 100 * 4 * height * width);

            while (command != "Tired!" || paintedRoom == room)
            {
                litersPaint = int.Parse(command);
                allPaint += litersPaint;
                paintedRoom += litersPaint;
                if (paintedRoom - room > 0)
                {
                    Console.WriteLine($"All walls are painted and you have {paintedRoom-room} l paint left!");
                    return;
                }
                if (paintedRoom == room)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    return;
                }
                
                command = Console.ReadLine();

            }
            Console.WriteLine($"{room-paintedRoom} quadratic m left.");
        }
    }
}
