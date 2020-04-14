using System;

namespace _06.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int desiredHigh = int.Parse(Console.ReadLine());
            int startingHigh = desiredHigh - 30;
            int shots = 3;
            bool flagFail = false;
            int highAtWhichHeFailed = 0;
            int maxJumpedHigh = 0;
            int jumps = 0;
            for (int i = startingHigh; i <= desiredHigh;)
            {
                int jumpingHigh = int.Parse(Console.ReadLine());
                jumps++;


                if (!(jumpingHigh > i))
                {
                    shots--;
                    if (shots == 0)
                    {
                        highAtWhichHeFailed = i;
                        flagFail = true;
                        break;
                    }
                }
                else
                {
                    shots = 3;
                    maxJumpedHigh = i;
                    i += 5;
                }


            }

            if (flagFail)
            {
                Console.WriteLine($"Tihomir failed at {highAtWhichHeFailed}cm after {jumps} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {maxJumpedHigh}cm after {jumps} jumps.");
            }

        }
    }
}
