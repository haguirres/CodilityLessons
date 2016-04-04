using System;
using System.Linq;

namespace Lesson_2_OddOccurrencesInArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] A = { 9, 4, 9, 3, 9, 3, 9, 7, 7 };
            Console.WriteLine("[{0}]", string.Join(", ", A));
            int value = GetUnpairedValue(A);
            Console.WriteLine("Valor sin par: " + value);
        }

        private static int GetUnpairedValue(int[] A)
        {
            //return A.Aggregate((x, y) => x ^ y);

            int current = 0;
            for (int i = 0; i < A.Length; i++)
            {
                current = current ^ A[i];
                Console.WriteLine(current);
            }
            return current;
        }
    }
}