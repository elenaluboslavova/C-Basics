using System;

namespace _04.CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucherPrice = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int ticketPrice = 0;
            int othersPrice = 0;
            int countTicket = 0;
            int countOthers = 0;

            while (input != "End")
            {
                
                if (input.Length > 8)
                {
                    ticketPrice = (int)input[0] + (int)input[1];
                    if (ticketPrice > voucherPrice)
                    {
                        Console.WriteLine(countTicket);
                        Console.WriteLine(countOthers);
                        return;
                    }
                    countTicket++;
                    voucherPrice -= ticketPrice;
                }
                else
                {
                    othersPrice = (int)input[0];
                    if (othersPrice > voucherPrice)
                    {
                        Console.WriteLine(countTicket);
                        Console.WriteLine(countOthers);
                        return;
                    }
                    countOthers++;
                    voucherPrice -= othersPrice;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(countTicket);
            Console.WriteLine(countOthers);
        }
    }
}
