using System;

namespace Lesson_3_FrogJmp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 10;
            int y = 85;
            decimal d = 30;
            GetJumpsNumber(x, y, d);
        }

        private static void GetJumpsNumber(int x, int y, decimal d)
        {
            int jumps = 0;

            if (x <= y)
            {
                if (x < y)
                {
                    jumps = (int)Math.Ceiling((y - x) / d);
                }
            }

            Console.WriteLine("Num. Jumps: " + jumps);
        }
    }
}