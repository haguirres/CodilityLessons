using System.Collections.Generic;
using System.Linq;
namespace Lesson_4_MaxCounters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] A = { 1, 2, 6, 5, 5, 5, 8, 9, 10, 11, 15, 13, 16,17 };

            int result = 0;

            result = solution(A);
            System.Console.WriteLine(result);
        }

        private static int solution(int[] A)
        {
            int count = 0;
            List<int> Counters = new List<int>();
            if (A != null || A.Length > 0)
            {
                int disorderValues = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (i + 1 < A.Length)
                    {
                        if (A[i] > A[i + 1])
                        {
                            disorderValues = A[i];
                        }
                        if (disorderValues >= A[i])
                        {
                            count++;
                        }
                        else
                        {
                            if (count > 0)
                            {
                                Counters.Add(count);
                            }
                            count = 0;
                        }
                    }
                }
            }
            return Counters.Count > 0 ? Counters.Min() : 0;
        }
    }
}