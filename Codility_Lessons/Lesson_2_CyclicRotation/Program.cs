using System;

namespace Lesson_2_CyclicRotation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 3;
            int[] B = RotateArray(A, K);
            Console.WriteLine("[{0}]", string.Join(", ", A));
            Console.WriteLine("Num. Rota: " + K);
            Console.WriteLine("[{0}]", string.Join(", ", B));
        }

        private static int[] RotateArray(int[] A, int K)
        {
            if (K == 0 || A.Length == 0)
            {
                return A;
            }
            int numeroRotaciones = K % A.Length;
            int[] N = new int[A.Length];
            if (numeroRotaciones != 0)
            {
                int aux = 0;
                for (int i = A.Length - numeroRotaciones; i < A.Length; i++)
                {
                    if (aux < numeroRotaciones)
                    {
                        N[aux] = A[i];
                        aux++;
                    }
                }
                int aux2 = numeroRotaciones;
                for (int i = 0; i < A.Length - numeroRotaciones; i++)
                {
                    if (aux2 > i)
                    {
                        N[aux2] = A[i];
                    }
                    aux2++;
                }
            }
            else
            {
                N = A;
            }
            return N;
        }
    }
}