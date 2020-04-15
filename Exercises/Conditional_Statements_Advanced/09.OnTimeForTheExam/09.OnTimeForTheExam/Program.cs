using System;

namespace _09.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това.
            //Ако е пристигнал по-рано повече от 30 минути, той е подранил. Ако е дошъл след часа на изпита, той е закъснял.

            //На първият ред отпечатайте:

            // “Late”, ако студентът пристига по-късно от часа на изпита.
            //•   “On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
            // •  “Early”, ако студентът пристига повече от 30 минути преди часа на изпита.


            //Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:

            //•   “mm minutes before the start” за идване по - рано с по-малко от час.
            //•   “hh: mm hours before the start” за подраняване с 1 час или повече.Минутите винаги печатайте с 2 цифри, например “1:05”.
            //•    “mm minutes after the start” за закъснение под час.
            //•   “hh: mm hours after the start” за закъснение от 1 час или повече.Минутите винаги печатайте с 2 цифри, например “1:03”.


            int examHour = int.Parse(Console.ReadLine());
            int examMins = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMins = int.Parse(Console.ReadLine());

            int examHourToMinutes = examHour * 60;
            int arrivalHourToMinutes = arrivalHour * 60;
            int totalExamMins = examHourToMinutes + examMins;
            int totalArrivalMins = arrivalHourToMinutes + arrivalMins;
            int difference = Math.Abs(totalExamMins - totalArrivalMins);
            int differenceH = difference / 60;
            int differenceM = difference % 60;

            if (totalExamMins > totalArrivalMins && difference == 0 || difference <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{differenceM} minutes before the start");
            }
            else if (difference > 30)
            {
                if (totalExamMins > totalArrivalMins)
                {
                    if (differenceH < 1)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{differenceM} minutes before the start");
                    }
                    else if (differenceH >= 1)
                    {
                        if (differenceM < 10)
                        {
                            Console.WriteLine("Early");
                            Console.WriteLine($"{differenceH} : 0{differenceM} hours before the start");
                        }
                        else if (differenceM >= 10)
                        {
                            Console.WriteLine("Early");
                            Console.WriteLine($"{differenceH} : {differenceM} hours before the start");
                        }
                    }
                }
                else if (totalExamMins < totalArrivalMins)
                {
                    if (differenceH < 1)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{differenceM} minutes after the start");
                    }
                    else if (differenceH >= 1)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{differenceH} : {differenceM} hours after the start");
                    }
                }


            }
        }
    }
}
