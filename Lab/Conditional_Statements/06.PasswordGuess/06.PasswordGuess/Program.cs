using System;

namespace _06.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string rightPassword = "s3cr3t!P@ssw0rd";
            if (password==rightPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
