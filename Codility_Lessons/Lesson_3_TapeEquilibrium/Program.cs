using System;
using System.Linq;

namespace Lesson_3_TapeEquilibrium
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] A = new int[] { 3, 1, 2, 4, 3 };

            Console.WriteLine(Solution(A));
        }

        private static int Solution(int[] A)
        {
            int sumN = 0;
            int[] array = new int[A.Length - 1];
            for (int i = 0; i < A.Length - 1; i++)
            {
                int sumP = 0;
                sumN += A[i];

                for (int j = i + 1; j < A.Length; j++)
                {
                    sumP += A[j];
                }
                array[i] = Math.Abs(sumN - sumP);
            }
            return array.Min();
        }
    }
}