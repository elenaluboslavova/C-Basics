using System;

namespace _02.Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int reservationDay = int.Parse(Console.ReadLine());
            int reservationMonth = int.Parse(Console.ReadLine());
            int accommodationDay = int.Parse(Console.ReadLine());
            int accommodationMonth = int.Parse(Console.ReadLine());
            int leavingDay = int.Parse(Console.ReadLine());
            int leavingMonth = int.Parse(Console.ReadLine());

            int night = 30;
            
            if (accommodationDay == reservationDay + 10)
            {
                night = 25;
            }

            if (accommodationMonth == reservationMonth + 1)
            {
                night = (leavingDay - accommodationDay) * 30 - (leavingDay - accommodationDay) * 30 * 20 / 100;
            }
            int sum = (leavingDay - accommodationDay) * night;

            Console.WriteLine($"Your stay from {accommodationDay}/" +
                $"{accommodationMonth} to {leavingDay}/{leavingMonth}" +
                $" will cost {sum:F2}");
        }
    }
}
