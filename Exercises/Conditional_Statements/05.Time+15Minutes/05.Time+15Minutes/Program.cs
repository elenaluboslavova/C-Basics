using System;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes<45)
            {
                
                if (hour==23 && minutes>=45)
                {
                    if (minutes < 55)
                    {
                        Console.WriteLine($"0:0{minutes + 15}");
                    }
                    else
                    {
                        Console.WriteLine($"0:{minutes + 15}");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"{hour}:{minutes + 15}");
                }
            }
            else
            {
                if (hour == 23 && minutes>=45)
                {
                    if (minutes < 54)
                    {
                        Console.WriteLine($"0:0{minutes - 45}");
                    }
                    else
                    {
                        Console.WriteLine($"0:{minutes - 45}");
                    }
                    
                }
                else
                {
                    if (minutes - 45 < 10)
                    {
                        Console.WriteLine($"{hour + 1}:0{minutes - 45}");
                    }
                    else
                    {
                        Console.WriteLine($"{hour + 1}:{minutes - 45}");
                    }
                }
                
                
            }
        }
    }
}
