using System;
using System.Linq;

namespace Lesson_3_PermMissingElem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] A = { 2, 3, 4, 5, 1 };
            Console.WriteLine(MissingElement(A));
        }

        private static int MissingElement(int[] A)
        {
            int element = 0;
            if (A != null)
            {
                if (A.Length > 0)
                {
                    var B = A.OrderBy(s => Convert.ToInt32(s)).ToArray();
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (B[i] != i + 1)
                        {
                            element = i + 1;
                            break;
                        }
                    }
                    element = element == 0 ? A.Length + 1 : element;
                }
                else
                {
                    element += 1;
                }
            }
            return element;
        }
    }
}