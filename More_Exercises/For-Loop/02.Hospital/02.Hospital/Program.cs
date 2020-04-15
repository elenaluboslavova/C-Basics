using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int patients = 0;
            int nPatients = 0;
            int pPatients = 0;
            int nPatientsCount = 0;
            int pPatientsCount = 0;

            for (int i = 1; i <= days; i++)
            {
                patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && nPatientsCount > pPatientsCount)
                {
                    if (patients >= 8)
                    {
                        pPatients = 8;
                        nPatients = patients - 8;
                    }
                    else
                    {
                        pPatients = patients;
                        nPatients = 0;
                    }
                }
                else
                {
                    if (patients >= 7)
                    {
                        pPatients = 7;
                        nPatients = patients - 7;
                    }
                    else
                    {
                        pPatients = patients;
                        nPatients = 0;
                    }
                }
                
                nPatientsCount += nPatients;
                pPatientsCount += pPatients;
            }
            Console.WriteLine($"Treated patients: {pPatientsCount}.");
            Console.WriteLine($"Untreated patients: {nPatientsCount}.");
        }
    }
}
