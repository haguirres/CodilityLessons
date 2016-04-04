using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Binary_Gap
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 529;
            string binaryNumber = Convert.ToString(N, 2);
            Console.WriteLine("Binary Number:"+ binaryNumber);
            int binaryGap = GetBinaryGap(binaryNumber);
            Console.WriteLine("Binary Gap: "+binaryGap);
        }

        private static int GetBinaryGap(string binaryNumber)
        {
            char[] binary = binaryNumber.ToCharArray();
            int firstone = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    firstone = i;
                    break;
                }
            }
            int lastone = 0;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    lastone = i;
                    break;
                }
            }
            int count = 0;
            int max = 0;
            for (int i = firstone; i <= lastone; i++)
            {
                if (binary[i] == '0')
                {
                    count++;
                }
                else
                {
                    if (max < count)
                    {
                        max = count;
                    }
                    count = 0;
                }
            }
            return max;
        }
    }
}
